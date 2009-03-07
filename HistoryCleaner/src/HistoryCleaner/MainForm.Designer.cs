namespace HistoryCleaner
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.buttonOpenRegedit = new System.Windows.Forms.Button();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpenRegedit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewRegKey = new System.Windows.Forms.ListView();
            this.columnDescription = new System.Windows.Forms.ColumnHeader();
            this.columnRegKey = new System.Windows.Forms.ColumnHeader();
            this.contextRegKey = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAllSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReleaseAllSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReverseAllSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.textLog = new System.Windows.Forms.TextBox();
            this.mainMenuStrip.SuspendLayout();
            this.contextRegKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExecute
            // 
            this.buttonExecute.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonExecute.Location = new System.Drawing.Point(571, 181);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 0;
            this.buttonExecute.Text = "実行";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // buttonOpenRegedit
            // 
            this.buttonOpenRegedit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOpenRegedit.Location = new System.Drawing.Point(545, 29);
            this.buttonOpenRegedit.Name = "buttonOpenRegedit";
            this.buttonOpenRegedit.Size = new System.Drawing.Size(150, 23);
            this.buttonOpenRegedit.TabIndex = 2;
            this.buttonOpenRegedit.Text = "レジストリエディタを開く";
            this.buttonOpenRegedit.UseVisualStyleBackColor = true;
            this.buttonOpenRegedit.Click += new System.EventHandler(this.ExecuteRegedit);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(707, 26);
            this.mainMenuStrip.TabIndex = 3;
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileOpenRegedit,
            this.menuFileSeparator1,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(85, 22);
            this.menuFile.Text = "ファイル(&F)";
            // 
            // menuFileOpenRegedit
            // 
            this.menuFileOpenRegedit.Name = "menuFileOpenRegedit";
            this.menuFileOpenRegedit.Size = new System.Drawing.Size(239, 22);
            this.menuFileOpenRegedit.Text = "レジストリエディタを開く(&O)";
            this.menuFileOpenRegedit.Click += new System.EventHandler(this.ExecuteRegedit);
            // 
            // menuFileSeparator1
            // 
            this.menuFileSeparator1.Name = "menuFileSeparator1";
            this.menuFileSeparator1.Size = new System.Drawing.Size(236, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(239, 22);
            this.menuFileExit.Text = "終了(&X)";
            this.menuFileExit.Click += new System.EventHandler(this.FormClose);
            // 
            // listViewRegKey
            // 
            this.listViewRegKey.CheckBoxes = true;
            this.listViewRegKey.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDescription,
            this.columnRegKey});
            this.listViewRegKey.ContextMenuStrip = this.contextRegKey;
            this.listViewRegKey.Location = new System.Drawing.Point(12, 29);
            this.listViewRegKey.Name = "listViewRegKey";
            this.listViewRegKey.Size = new System.Drawing.Size(527, 258);
            this.listViewRegKey.TabIndex = 4;
            this.listViewRegKey.UseCompatibleStateImageBehavior = false;
            this.listViewRegKey.View = System.Windows.Forms.View.Details;
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "説明";
            // 
            // columnRegKey
            // 
            this.columnRegKey.Text = "レジストリキー";
            // 
            // contextRegKey
            // 
            this.contextRegKey.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAllSelect,
            this.menuReleaseAllSelection,
            this.menuReverseAllSelection});
            this.contextRegKey.Name = "contextRegKey";
            this.contextRegKey.Size = new System.Drawing.Size(179, 70);
            // 
            // menuAllSelect
            // 
            this.menuAllSelect.Name = "menuAllSelect";
            this.menuAllSelect.Size = new System.Drawing.Size(178, 22);
            this.menuAllSelect.Text = "すべて選択(&S)";
            this.menuAllSelect.Click += new System.EventHandler(this.menuAllSelect_Click);
            // 
            // menuReleaseAllSelection
            // 
            this.menuReleaseAllSelection.Name = "menuReleaseAllSelection";
            this.menuReleaseAllSelection.Size = new System.Drawing.Size(178, 22);
            this.menuReleaseAllSelection.Text = "すべて選択解除(&R)";
            this.menuReleaseAllSelection.Click += new System.EventHandler(this.menuReleaseAllSelection_Click);
            // 
            // menuReverseAllSelection
            // 
            this.menuReverseAllSelection.Name = "menuReverseAllSelection";
            this.menuReverseAllSelection.Size = new System.Drawing.Size(178, 22);
            this.menuReverseAllSelection.Text = "選択の切り替え(&E)";
            this.menuReverseAllSelection.Click += new System.EventHandler(this.menuReverseAllSelection_Click);
            // 
            // textLog
            // 
            this.textLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textLog.Location = new System.Drawing.Point(12, 293);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textLog.Size = new System.Drawing.Size(683, 107);
            this.textLog.TabIndex = 5;
            this.textLog.WordWrap = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 412);
            this.Controls.Add(this.listViewRegKey);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.buttonOpenRegedit);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "履歴の削除";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.contextRegKey.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button buttonOpenRegedit;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpenRegedit;
        private System.Windows.Forms.ToolStripSeparator menuFileSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ListView listViewRegKey;
        private System.Windows.Forms.ColumnHeader columnDescription;
        private System.Windows.Forms.ColumnHeader columnRegKey;
        private System.Windows.Forms.TextBox textLog;
        private System.Windows.Forms.ContextMenuStrip contextRegKey;
        private System.Windows.Forms.ToolStripMenuItem menuAllSelect;
        private System.Windows.Forms.ToolStripMenuItem menuReleaseAllSelection;
        private System.Windows.Forms.ToolStripMenuItem menuReverseAllSelection;
    }
}

