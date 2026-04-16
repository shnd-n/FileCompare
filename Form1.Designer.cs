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
            leftFirPnl = new Panel();
            btnLeftDir = new Button();
            lblAppName = new Label();
            leftThirPnl = new Panel();
            lvwLeftDir = new ListView();
            leftSecPnl = new Panel();
            btnCopyFromLeft = new Button();
            txtLeftDir = new TextBox();
            rightSecPnl = new Panel();
            lvwrightDir = new ListView();
            rightFirPnl = new Panel();
            btnRightDir = new Button();
            rightThirPnl = new Panel();
            btnCopyFromRight = new Button();
            txtRightDir = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitCont).BeginInit();
            splitCont.Panel1.SuspendLayout();
            splitCont.Panel2.SuspendLayout();
            splitCont.SuspendLayout();
            leftFirPnl.SuspendLayout();
            leftThirPnl.SuspendLayout();
            leftSecPnl.SuspendLayout();
            rightSecPnl.SuspendLayout();
            rightFirPnl.SuspendLayout();
            rightThirPnl.SuspendLayout();
            SuspendLayout();
            // 
            // splitCont
            // 
            splitCont.Dock = DockStyle.Fill;
            splitCont.Location = new Point(0, 0);
            splitCont.Name = "splitCont";
            // 
            // splitCont.Panel1
            // 
            splitCont.Panel1.Controls.Add(leftFirPnl);
            splitCont.Panel1.Controls.Add(leftThirPnl);
            splitCont.Panel1.Controls.Add(leftSecPnl);
            // 
            // splitCont.Panel2
            // 
            splitCont.Panel2.Controls.Add(rightSecPnl);
            splitCont.Panel2.Controls.Add(rightFirPnl);
            splitCont.Panel2.Controls.Add(rightThirPnl);
            splitCont.Size = new Size(800, 450);
            splitCont.SplitterDistance = 400;
            splitCont.TabIndex = 0;
            // 
            // leftFirPnl
            // 
            leftFirPnl.Controls.Add(btnLeftDir);
            leftFirPnl.Controls.Add(lblAppName);
            leftFirPnl.Location = new Point(22, 12);
            leftFirPnl.Name = "leftFirPnl";
            leftFirPnl.Size = new Size(375, 87);
            leftFirPnl.TabIndex = 6;
            // 
            // btnLeftDir
            // 
            btnLeftDir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLeftDir.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLeftDir.Location = new Point(285, 29);
            btnLeftDir.Name = "btnLeftDir";
            btnLeftDir.Size = new Size(75, 35);
            btnLeftDir.TabIndex = 1;
            btnLeftDir.Text = ">>>";
            btnLeftDir.UseVisualStyleBackColor = true;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(3, 12);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(199, 40);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "File Compare";
            // 
            // leftThirPnl
            // 
            leftThirPnl.Controls.Add(lvwLeftDir);
            leftThirPnl.Location = new Point(22, 161);
            leftThirPnl.Name = "leftThirPnl";
            leftThirPnl.Size = new Size(375, 277);
            leftThirPnl.TabIndex = 8;
            // 
            // lvwLeftDir
            // 
            lvwLeftDir.Location = new Point(3, 3);
            lvwLeftDir.Name = "lvwLeftDir";
            lvwLeftDir.Size = new Size(369, 274);
            lvwLeftDir.TabIndex = 0;
            lvwLeftDir.UseCompatibleStateImageBehavior = false;
            // 
            // leftSecPnl
            // 
            leftSecPnl.Controls.Add(btnCopyFromLeft);
            leftSecPnl.Controls.Add(txtLeftDir);
            leftSecPnl.Location = new Point(22, 105);
            leftSecPnl.Name = "leftSecPnl";
            leftSecPnl.Size = new Size(375, 50);
            leftSecPnl.TabIndex = 7;
            // 
            // btnCopyFromLeft
            // 
            btnCopyFromLeft.Font = new Font("맑은 고딕", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCopyFromLeft.Location = new Point(297, 7);
            btnCopyFromLeft.Name = "btnCopyFromLeft";
            btnCopyFromLeft.Size = new Size(63, 31);
            btnCopyFromLeft.TabIndex = 2;
            btnCopyFromLeft.Text = "폴더 선택";
            btnCopyFromLeft.UseVisualStyleBackColor = true;
            // 
            // txtLeftDir
            // 
            txtLeftDir.Location = new Point(3, 15);
            txtLeftDir.Name = "txtLeftDir";
            txtLeftDir.Size = new Size(288, 23);
            txtLeftDir.TabIndex = 0;
            // 
            // rightSecPnl
            // 
            rightSecPnl.Controls.Add(lvwrightDir);
            rightSecPnl.Location = new Point(9, 161);
            rightSecPnl.Name = "rightSecPnl";
            rightSecPnl.Size = new Size(375, 277);
            rightSecPnl.TabIndex = 14;
            // 
            // lvwrightDir
            // 
            lvwrightDir.Location = new Point(3, 3);
            lvwrightDir.Name = "lvwrightDir";
            lvwrightDir.Size = new Size(369, 274);
            lvwrightDir.TabIndex = 1;
            lvwrightDir.UseCompatibleStateImageBehavior = false;
            // 
            // rightFirPnl
            // 
            rightFirPnl.Controls.Add(btnRightDir);
            rightFirPnl.Location = new Point(9, 12);
            rightFirPnl.Name = "rightFirPnl";
            rightFirPnl.Size = new Size(375, 87);
            rightFirPnl.TabIndex = 12;
            // 
            // btnRightDir
            // 
            btnRightDir.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnRightDir.Location = new Point(18, 29);
            btnRightDir.Name = "btnRightDir";
            btnRightDir.Size = new Size(75, 35);
            btnRightDir.TabIndex = 2;
            btnRightDir.Text = "<<<";
            btnRightDir.UseVisualStyleBackColor = true;
            // 
            // rightThirPnl
            // 
            rightThirPnl.Controls.Add(btnCopyFromRight);
            rightThirPnl.Controls.Add(txtRightDir);
            rightThirPnl.Location = new Point(9, 105);
            rightThirPnl.Name = "rightThirPnl";
            rightThirPnl.Size = new Size(375, 50);
            rightThirPnl.TabIndex = 13;
            // 
            // btnCopyFromRight
            // 
            btnCopyFromRight.Font = new Font("맑은 고딕", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCopyFromRight.Location = new Point(299, 7);
            btnCopyFromRight.Name = "btnCopyFromRight";
            btnCopyFromRight.Size = new Size(63, 31);
            btnCopyFromRight.TabIndex = 4;
            btnCopyFromRight.Text = "폴더 선택";
            btnCopyFromRight.UseVisualStyleBackColor = true;
            // 
            // txtRightDir
            // 
            txtRightDir.Location = new Point(5, 15);
            txtRightDir.Name = "txtRightDir";
            txtRightDir.Size = new Size(288, 23);
            txtRightDir.TabIndex = 3;
            txtRightDir.TextChanged += txtRightDir_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitCont);
            Name = "Form1";
            Text = "File Compare v1.0";
            splitCont.Panel1.ResumeLayout(false);
            splitCont.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitCont).EndInit();
            splitCont.ResumeLayout(false);
            leftFirPnl.ResumeLayout(false);
            leftFirPnl.PerformLayout();
            leftThirPnl.ResumeLayout(false);
            leftSecPnl.ResumeLayout(false);
            leftSecPnl.PerformLayout();
            rightSecPnl.ResumeLayout(false);
            rightFirPnl.ResumeLayout(false);
            rightThirPnl.ResumeLayout(false);
            rightThirPnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitCont;
        private Panel leftFirPnl;
        private Button btnLeftDir;
        private Label lblAppName;
        private Panel leftThirPnl;
        private ListView lvwLeftDir;
        private Panel leftSecPnl;
        private Button btnCopyFromLeft;
        private TextBox txtLeftDir;
        private Panel rightSecPnl;
        private ListView lvwrightDir;
        private Panel rightFirPnl;
        private Button btnRightDir;
        private Panel rightThirPnl;
        private Button btnCopyFromRight;
        private TextBox txtRightDir;
    }
}
