namespace FileCompare
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitCont = new SplitContainer();
            left2Pnl = new Panel();
            btnCopyFromLeft = new Button();
            txtLeftDir = new TextBox();
            left3Pnl = new Panel();
            lvwLeftDir = new ListView();
            name = new ColumnHeader();
            size = new ColumnHeader();
            day = new ColumnHeader();
            left1Pnl = new Panel();
            btnLeftDir = new Button();
            lblAppName = new Label();
            right3Pnl = new Panel();
            lvwRightDir = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            right2Pnl = new Panel();
            btnCopyFromRight = new Button();
            txtRightDir = new TextBox();
            right1Pnl = new Panel();
            btnRightDir = new Button();
            columnHeader3 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)splitCont).BeginInit();
            splitCont.Panel1.SuspendLayout();
            splitCont.Panel2.SuspendLayout();
            splitCont.SuspendLayout();
            left2Pnl.SuspendLayout();
            left3Pnl.SuspendLayout();
            left1Pnl.SuspendLayout();
            right3Pnl.SuspendLayout();
            right2Pnl.SuspendLayout();
            right1Pnl.SuspendLayout();
            SuspendLayout();
            // 
            // splitCont
            // 
            splitCont.Dock = DockStyle.Fill;
            splitCont.Location = new Point(5, 5);
            splitCont.Name = "splitCont";
            // 
            // splitCont.Panel1
            // 
            splitCont.Panel1.Controls.Add(left2Pnl);
            splitCont.Panel1.Controls.Add(left3Pnl);
            splitCont.Panel1.Controls.Add(left1Pnl);
            // 
            // splitCont.Panel2
            // 
            splitCont.Panel2.Controls.Add(right3Pnl);
            splitCont.Panel2.Controls.Add(right2Pnl);
            splitCont.Panel2.Controls.Add(right1Pnl);
            splitCont.Size = new Size(790, 440);
            splitCont.SplitterDistance = 400;
            splitCont.TabIndex = 0;
            // 
            // left2Pnl
            // 
            left2Pnl.Controls.Add(btnCopyFromLeft);
            left2Pnl.Controls.Add(txtLeftDir);
            left2Pnl.Dock = DockStyle.Top;
            left2Pnl.Location = new Point(0, 86);
            left2Pnl.Name = "left2Pnl";
            left2Pnl.Size = new Size(400, 57);
            left2Pnl.TabIndex = 6;
            // 
            // btnCopyFromLeft
            // 
            btnCopyFromLeft.Anchor = AnchorStyles.Right;
            btnCopyFromLeft.Font = new Font("맑은 고딕", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCopyFromLeft.Location = new Point(334, 14);
            btnCopyFromLeft.Name = "btnCopyFromLeft";
            btnCopyFromLeft.Size = new Size(63, 31);
            btnCopyFromLeft.TabIndex = 2;
            btnCopyFromLeft.Text = "폴더 선택";
            btnCopyFromLeft.UseVisualStyleBackColor = true;
            btnCopyFromLeft.Click += btnCopyFromLeft_Click;
            // 
            // txtLeftDir
            // 
            txtLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLeftDir.Location = new Point(9, 18);
            txtLeftDir.Name = "txtLeftDir";
            txtLeftDir.Size = new Size(312, 23);
            txtLeftDir.TabIndex = 0;
            // 
            // left3Pnl
            // 
            left3Pnl.Controls.Add(lvwLeftDir);
            left3Pnl.Dock = DockStyle.Fill;
            left3Pnl.Location = new Point(0, 86);
            left3Pnl.Name = "left3Pnl";
            left3Pnl.Size = new Size(400, 354);
            left3Pnl.TabIndex = 8;
            // 
            // lvwLeftDir
            // 
            lvwLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvwLeftDir.Columns.AddRange(new ColumnHeader[] { name, size, day });
            lvwLeftDir.FullRowSelect = true;
            lvwLeftDir.GridLines = true;
            lvwLeftDir.Location = new Point(9, 63);
            lvwLeftDir.Name = "lvwLeftDir";
            lvwLeftDir.Size = new Size(381, 274);
            lvwLeftDir.TabIndex = 0;
            lvwLeftDir.UseCompatibleStateImageBehavior = false;
            lvwLeftDir.View = View.Details;
            // 
            // name
            // 
            name.Text = "이름";
            name.Width = 200;
            // 
            // size
            // 
            size.Text = "크기";
            // 
            // day
            // 
            day.Text = "수정일";
            day.Width = 100;
            // 
            // left1Pnl
            // 
            left1Pnl.Controls.Add(btnLeftDir);
            left1Pnl.Controls.Add(lblAppName);
            left1Pnl.Dock = DockStyle.Top;
            left1Pnl.Location = new Point(0, 0);
            left1Pnl.Name = "left1Pnl";
            left1Pnl.Size = new Size(400, 86);
            left1Pnl.TabIndex = 7;
            // 
            // btnLeftDir
            // 
            btnLeftDir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLeftDir.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLeftDir.Location = new Point(316, 34);
            btnLeftDir.Name = "btnLeftDir";
            btnLeftDir.Size = new Size(75, 35);
            btnLeftDir.TabIndex = 3;
            btnLeftDir.Text = ">>>";
            btnLeftDir.UseVisualStyleBackColor = true;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(9, 17);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(199, 40);
            lblAppName.TabIndex = 2;
            lblAppName.Text = "File Compare";
            // 
            // right3Pnl
            // 
            right3Pnl.Controls.Add(lvwRightDir);
            right3Pnl.Dock = DockStyle.Fill;
            right3Pnl.Location = new Point(0, 143);
            right3Pnl.Name = "right3Pnl";
            right3Pnl.Size = new Size(386, 297);
            right3Pnl.TabIndex = 14;
            // 
            // lvwRightDir
            // 
            lvwRightDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvwRightDir.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader1, columnHeader4 });
            lvwRightDir.FullRowSelect = true;
            lvwRightDir.GridLines = true;
            lvwRightDir.Location = new Point(7, 6);
            lvwRightDir.Name = "lvwRightDir";
            lvwRightDir.Size = new Size(369, 274);
            lvwRightDir.TabIndex = 1;
            lvwRightDir.UseCompatibleStateImageBehavior = false;
            lvwRightDir.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "이름";
            columnHeader2.Width = 200;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "크기";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "수정일";
            columnHeader4.Width = 100;
            // 
            // right2Pnl
            // 
            right2Pnl.Controls.Add(btnCopyFromRight);
            right2Pnl.Controls.Add(txtRightDir);
            right2Pnl.Dock = DockStyle.Top;
            right2Pnl.Location = new Point(0, 86);
            right2Pnl.Name = "right2Pnl";
            right2Pnl.Size = new Size(386, 57);
            right2Pnl.TabIndex = 12;
            // 
            // btnCopyFromRight
            // 
            btnCopyFromRight.Anchor = AnchorStyles.Right;
            btnCopyFromRight.Font = new Font("맑은 고딕", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCopyFromRight.Location = new Point(313, 14);
            btnCopyFromRight.Name = "btnCopyFromRight";
            btnCopyFromRight.Size = new Size(63, 31);
            btnCopyFromRight.TabIndex = 4;
            btnCopyFromRight.Text = "폴더 선택";
            btnCopyFromRight.UseVisualStyleBackColor = true;
            btnCopyFromRight.Click += btnCopyFromRight_Click;
            // 
            // txtRightDir
            // 
            txtRightDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRightDir.Location = new Point(7, 22);
            txtRightDir.Name = "txtRightDir";
            txtRightDir.Size = new Size(300, 23);
            txtRightDir.TabIndex = 3;
            // 
            // right1Pnl
            // 
            right1Pnl.Controls.Add(btnRightDir);
            right1Pnl.Dock = DockStyle.Top;
            right1Pnl.Location = new Point(0, 0);
            right1Pnl.Name = "right1Pnl";
            right1Pnl.Size = new Size(386, 86);
            right1Pnl.TabIndex = 13;
            // 
            // btnRightDir
            // 
            btnRightDir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRightDir.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnRightDir.Location = new Point(14, 34);
            btnRightDir.Name = "btnRightDir";
            btnRightDir.Size = new Size(75, 35);
            btnRightDir.TabIndex = 3;
            btnRightDir.Text = "<<<";
            btnRightDir.UseVisualStyleBackColor = true;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "수정일";
            columnHeader3.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitCont);
            Name = "Form1";
            Padding = new Padding(5);
            Text = "File Compare v1.0";
            splitCont.Panel1.ResumeLayout(false);
            splitCont.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitCont).EndInit();
            splitCont.ResumeLayout(false);
            left2Pnl.ResumeLayout(false);
            left2Pnl.PerformLayout();
            left3Pnl.ResumeLayout(false);
            left1Pnl.ResumeLayout(false);
            left1Pnl.PerformLayout();
            right3Pnl.ResumeLayout(false);
            right2Pnl.ResumeLayout(false);
            right2Pnl.PerformLayout();
            right1Pnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitCont;
        private Panel left2Pnl;
        private Panel left3Pnl;
        private ListView lvwLeftDir;
        private Panel left1Pnl;
        private Button btnCopyFromLeft;
        private TextBox txtLeftDir;
        private Panel right3Pnl;
        private ListView lvwRightDir;
        private Panel right2Pnl;
        private Panel right1Pnl;
        private Button btnCopyFromRight;
        private TextBox txtRightDir;
        private Button btnLeftDir;
        private Label lblAppName;
        private Button btnRightDir;
        private ColumnHeader size;
        private ColumnHeader day;
        private ColumnHeader name;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader4;
    }
}
