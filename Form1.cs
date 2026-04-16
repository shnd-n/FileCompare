namespace FileCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopyFromLeft_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                dlg.Description = "폴더를 선택하세요.";
                // 최신 스타일의 폴더 선택창을 사용하고 싶다면 true (Windows Vista 이상)
                dlg.ShowNewFolderButton = true;

                // 현재 텍스트박스 경로를 초기값으로 설정
                if (!string.IsNullOrWhiteSpace(txtLeftDir.Text) && Directory.Exists(txtLeftDir.Text))
                {
                    dlg.SelectedPath = txtLeftDir.Text;
                }

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtLeftDir.Text = dlg.SelectedPath;
                    PopulateListView(lvwLeftDir, dlg.SelectedPath);
                    RefreshComparison();
                }
            }
        }

        private void btnCopyFromRight_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                dlg.Description = "폴더를 선택하세요.";
                // 최신 스타일의 폴더 선택창을 사용하고 싶다면 true (Windows Vista 이상)
                dlg.ShowNewFolderButton = true;

                // 현재 텍스트박스 경로를 초기값으로 설정
                if (!string.IsNullOrWhiteSpace(txtRightDir.Text) && Directory.Exists(txtRightDir.Text))
                {
                    dlg.SelectedPath = txtRightDir.Text;
                }

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtRightDir.Text = dlg.SelectedPath;
                    PopulateListView(lvwRightDir, dlg.SelectedPath);
                    RefreshComparison();
                }
            }
        }

        private void PopulateListView(ListView lv, string folderPath)
        {
            lv.BeginUpdate(); // 화면 깜빡임 방지 시작
            lv.Items.Clear();

            try
            {
                // 1. 폴더(디렉터리) 목록 가져오기 및 추가
                var dirs = Directory.EnumerateDirectories(folderPath)
                                    .Select(p => new DirectoryInfo(p))
                                    .OrderBy(d => d.Name); // 여기서 콤마(,) 제거됨

                foreach (var d in dirs)
                {
                    var item = new ListViewItem(d.Name);
                    item.SubItems.Add("<DIR>"); // 폴더임을 표시
                    item.SubItems.Add(d.LastWriteTime.ToString("g")); // 수정일자
                    lv.Items.Add(item);
                }

                // 2. 파일 목록 가져오기 및 추가
                var files = Directory.EnumerateFiles(folderPath)
                                     .Select(p => new FileInfo(p))
                                     .OrderBy(f => f.Name);

                foreach (var f in files)
                {
                    var item = new ListViewItem(f.Name);
                    item.SubItems.Add(f.Length.ToString("N0") + " 바이트");
                    item.SubItems.Add(f.LastWriteTime.ToString("g"));
                    item.Tag = f;
                    lv.Items.Add(item);
                }
                // 3. 컬럼 너비 자동 조정
                for (int i = 0; i < lv.Columns.Count; i++)
                {
                    lv.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
                }
            }
            catch (DirectoryNotFoundException) 
            {
                MessageBox.Show(this, "폴더를 찾을 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex) // 그 외 일반적인 예외 처리
            {
                MessageBox.Show(this, "입출력 오류: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                lv.EndUpdate(); // 화면 업데이트 재개
            }
        }

        private void RefreshComparison()
        {
            // 양쪽 리스트뷰가 비어있지 않을 때만 실행 (선택사항)
            if (lvwLeftDir.Items.Count == 0 && lvwRightDir.Items.Count == 0) return;

            lvwLeftDir.BeginUpdate();
            lvwRightDir.BeginUpdate();

            try
            {
                // 1. 왼쪽 리스트뷰 기준 비교 (왼쪽 색칠)
                foreach (ListViewItem leftItem in lvwLeftDir.Items)
                {
                    var rightItem = lvwRightDir.FindItemWithText(leftItem.Text);
                    SetItemColor(leftItem, rightItem);
                }

                // 2. 오른쪽 리스트뷰 기준 비교 (오른쪽 색칠)
                foreach (ListViewItem rightItem in lvwRightDir.Items)
                {
                    var leftItem = lvwLeftDir.FindItemWithText(rightItem.Text);
                    // 오른쪽 아이템 입장에서 왼쪽과 비교
                    SetItemColor(rightItem, leftItem);
                }
            }
            finally
            {
                lvwLeftDir.EndUpdate();
                lvwRightDir.EndUpdate();
            }
        }

        // 색상을 결정하는 보조 메서드 (코드 중복 방지)
        private void SetItemColor(ListViewItem targetItem, ListViewItem opponentItem)
        {
            if (opponentItem == null)
            {
                targetItem.ForeColor = Color.Purple; // 3단계: 단독 파일
                return;
            }

            // Tag에 FileInfo가 들어있다고 가정 (PopulateListView에서 넣어줘야 함)
            var targetFile = targetItem.Tag as FileInfo;
            var opponentFile = opponentItem.Tag as FileInfo;

            if (targetFile != null && opponentFile != null)
            {
                if (targetFile.LastWriteTime == opponentFile.LastWriteTime)
                {
                    targetItem.ForeColor = Color.Black; // 1단계: 동일 파일
                }
                else
                {
                    // 2단계: 다름 (New 빨강, Old 회색)
                    if (targetFile.LastWriteTime > opponentFile.LastWriteTime)
                        targetItem.ForeColor = Color.Red;
                    else
                        targetItem.ForeColor = Color.Gray;
                }
            }
        }
    }
}
