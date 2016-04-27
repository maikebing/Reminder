namespace Reminder
{
    partial class MemoForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.memoTitleList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.submitChange = new System.Windows.Forms.Button();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.newMemo = new System.Windows.Forms.Button();
            this.purgeMemo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // memoTitleList
            // 
            this.memoTitleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoTitleList.FormattingEnabled = true;
            this.memoTitleList.HorizontalScrollbar = true;
            this.memoTitleList.ItemHeight = 12;
            this.memoTitleList.Location = new System.Drawing.Point(0, 0);
            this.memoTitleList.Name = "memoTitleList";
            this.memoTitleList.Size = new System.Drawing.Size(209, 482);
            this.memoTitleList.TabIndex = 0;
            this.memoTitleList.DoubleClick += new System.EventHandler(this.memoTitleList_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "タイトル";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.purgeMemo);
            this.panel1.Controls.Add(this.newMemo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.submitChange);
            this.panel1.Controls.Add(this.textTextBox);
            this.panel1.Controls.Add(this.titleTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 482);
            this.panel1.TabIndex = 2;
            // 
            // submitChange
            // 
            this.submitChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitChange.Location = new System.Drawing.Point(351, 456);
            this.submitChange.Name = "submitChange";
            this.submitChange.Size = new System.Drawing.Size(75, 23);
            this.submitChange.TabIndex = 4;
            this.submitChange.Text = "変更";
            this.submitChange.UseVisualStyleBackColor = true;
            this.submitChange.Click += new System.EventHandler(this.submitChange_Click);
            // 
            // textTextBox
            // 
            this.textTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTextBox.Location = new System.Drawing.Point(49, 40);
            this.textTextBox.Multiline = true;
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(377, 410);
            this.textTextBox.TabIndex = 3;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextBox.Location = new System.Drawing.Point(49, 3);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(377, 19);
            this.titleTextBox.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(672, 506);
            this.splitContainer1.SplitterDistance = 224;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.memoTitleList);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 482);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "内容";
            // 
            // newMemo
            // 
            this.newMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newMemo.Location = new System.Drawing.Point(270, 456);
            this.newMemo.Name = "newMemo";
            this.newMemo.Size = new System.Drawing.Size(75, 23);
            this.newMemo.TabIndex = 6;
            this.newMemo.Text = "新規";
            this.newMemo.UseVisualStyleBackColor = true;
            this.newMemo.Click += new System.EventHandler(this.newMemo_Click);
            // 
            // purgeMemo
            // 
            this.purgeMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.purgeMemo.Location = new System.Drawing.Point(49, 456);
            this.purgeMemo.Name = "purgeMemo";
            this.purgeMemo.Size = new System.Drawing.Size(75, 23);
            this.purgeMemo.TabIndex = 7;
            this.purgeMemo.Text = "消去";
            this.purgeMemo.UseVisualStyleBackColor = true;
            this.purgeMemo.Click += new System.EventHandler(this.purgeMemo_Click);
            // 
            // MemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 506);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MemoForm";
            this.Text = "ルマンド";
            this.Load += new System.EventHandler(this.MemoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox memoTitleList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button submitChange;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button newMemo;
        private System.Windows.Forms.Button purgeMemo;
    }
}

