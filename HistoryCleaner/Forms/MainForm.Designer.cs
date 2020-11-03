namespace HistoryCleaner.Forms
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
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.flowButton = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAllSelect = new System.Windows.Forms.Button();
            this.buttonReleaseAllSelection = new System.Windows.Forms.Button();
            this.buttonReverseAllSelection = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.mainMenuStrip.SuspendLayout();
            this.contextRegKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.flowButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExecute
            // 
            this.buttonExecute.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonExecute.Location = new System.Drawing.Point(15, 179);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(200, 38);
            this.buttonExecute.TabIndex = 4;
            this.buttonExecute.Text = "実行";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.ExecuteEvent);
            // 
            // buttonOpenRegedit
            // 
            this.buttonOpenRegedit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOpenRegedit.Location = new System.Drawing.Point(15, 3);
            this.buttonOpenRegedit.Name = "buttonOpenRegedit";
            this.buttonOpenRegedit.Size = new System.Drawing.Size(200, 38);
            this.buttonOpenRegedit.TabIndex = 0;
            this.buttonOpenRegedit.Text = "レジストリエディタを開く";
            this.buttonOpenRegedit.UseVisualStyleBackColor = true;
            this.buttonOpenRegedit.Click += new System.EventHandler(this.ExecuteRegeditEvent);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1300, 28);
            this.mainMenuStrip.TabIndex = 0;
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileOpenRegedit,
            this.menuFileSeparator1,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(82, 24);
            this.menuFile.Text = "ファイル(&F)";
            // 
            // menuFileOpenRegedit
            // 
            this.menuFileOpenRegedit.Name = "menuFileOpenRegedit";
            this.menuFileOpenRegedit.Size = new System.Drawing.Size(246, 26);
            this.menuFileOpenRegedit.Text = "レジストリエディタを開く(&O)";
            this.menuFileOpenRegedit.Click += new System.EventHandler(this.ExecuteRegeditEvent);
            // 
            // menuFileSeparator1
            // 
            this.menuFileSeparator1.Name = "menuFileSeparator1";
            this.menuFileSeparator1.Size = new System.Drawing.Size(243, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(246, 26);
            this.menuFileExit.Text = "終了(&X)";
            this.menuFileExit.Click += new System.EventHandler(this.FormCloseEvent);
            // 
            // listViewRegKey
            // 
            this.listViewRegKey.CheckBoxes = true;
            this.listViewRegKey.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDescription,
            this.columnRegKey});
            this.listViewRegKey.ContextMenuStrip = this.contextRegKey;
            this.listViewRegKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewRegKey.HideSelection = false;
            this.listViewRegKey.Location = new System.Drawing.Point(16, 8);
            this.listViewRegKey.Name = "listViewRegKey";
            this.listViewRegKey.Size = new System.Drawing.Size(1050, 662);
            this.listViewRegKey.TabIndex = 0;
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
            this.contextRegKey.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextRegKey.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAllSelect,
            this.menuReleaseAllSelection,
            this.menuReverseAllSelection});
            this.contextRegKey.Name = "contextRegKey";
            this.contextRegKey.Size = new System.Drawing.Size(193, 76);
            // 
            // menuAllSelect
            // 
            this.menuAllSelect.Name = "menuAllSelect";
            this.menuAllSelect.Size = new System.Drawing.Size(192, 24);
            this.menuAllSelect.Text = "すべて選択(&S)";
            this.menuAllSelect.Click += new System.EventHandler(this.SelectAllEvent);
            // 
            // menuReleaseAllSelection
            // 
            this.menuReleaseAllSelection.Name = "menuReleaseAllSelection";
            this.menuReleaseAllSelection.Size = new System.Drawing.Size(192, 24);
            this.menuReleaseAllSelection.Text = "すべて選択解除(&R)";
            this.menuReleaseAllSelection.Click += new System.EventHandler(this.ReleaseAllSelectionEvent);
            // 
            // menuReverseAllSelection
            // 
            this.menuReverseAllSelection.Name = "menuReverseAllSelection";
            this.menuReverseAllSelection.Size = new System.Drawing.Size(192, 24);
            this.menuReverseAllSelection.Text = "選択の切り替え(&E)";
            this.menuReverseAllSelection.Click += new System.EventHandler(this.ReverseAllSelectionEvent);
            // 
            // textLog
            // 
            this.textLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textLog.Location = new System.Drawing.Point(16, 6);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textLog.Size = new System.Drawing.Size(1268, 252);
            this.textLog.TabIndex = 0;
            this.textLog.WordWrap = false;
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 28);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.listViewRegKey);
            this.mainSplitContainer.Panel1.Controls.Add(this.flowButton);
            this.mainSplitContainer.Panel1.Padding = new System.Windows.Forms.Padding(16, 8, 16, 6);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.textLog);
            this.mainSplitContainer.Panel2.Padding = new System.Windows.Forms.Padding(16, 6, 16, 16);
            this.mainSplitContainer.Size = new System.Drawing.Size(1300, 954);
            this.mainSplitContainer.SplitterDistance = 676;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // flowButton
            // 
            this.flowButton.AutoSize = true;
            this.flowButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowButton.Controls.Add(this.buttonOpenRegedit);
            this.flowButton.Controls.Add(this.buttonAllSelect);
            this.flowButton.Controls.Add(this.buttonReleaseAllSelection);
            this.flowButton.Controls.Add(this.buttonReverseAllSelection);
            this.flowButton.Controls.Add(this.buttonExecute);
            this.flowButton.Controls.Add(this.buttonExit);
            this.flowButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowButton.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowButton.Location = new System.Drawing.Point(1066, 8);
            this.flowButton.Name = "flowButton";
            this.flowButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.flowButton.Size = new System.Drawing.Size(218, 662);
            this.flowButton.TabIndex = 1;
            // 
            // buttonAllSelect
            // 
            this.buttonAllSelect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAllSelect.Location = new System.Drawing.Point(15, 47);
            this.buttonAllSelect.Name = "buttonAllSelect";
            this.buttonAllSelect.Size = new System.Drawing.Size(200, 38);
            this.buttonAllSelect.TabIndex = 1;
            this.buttonAllSelect.Text = "すべて選択";
            this.buttonAllSelect.UseVisualStyleBackColor = true;
            this.buttonAllSelect.Click += new System.EventHandler(this.SelectAllEvent);
            // 
            // buttonReleaseAllSelection
            // 
            this.buttonReleaseAllSelection.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonReleaseAllSelection.Location = new System.Drawing.Point(15, 91);
            this.buttonReleaseAllSelection.Name = "buttonReleaseAllSelection";
            this.buttonReleaseAllSelection.Size = new System.Drawing.Size(200, 38);
            this.buttonReleaseAllSelection.TabIndex = 2;
            this.buttonReleaseAllSelection.Text = "すべて選択解除";
            this.buttonReleaseAllSelection.UseVisualStyleBackColor = true;
            this.buttonReleaseAllSelection.Click += new System.EventHandler(this.ReleaseAllSelectionEvent);
            // 
            // buttonReverseAllSelection
            // 
            this.buttonReverseAllSelection.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonReverseAllSelection.Location = new System.Drawing.Point(15, 135);
            this.buttonReverseAllSelection.Name = "buttonReverseAllSelection";
            this.buttonReverseAllSelection.Size = new System.Drawing.Size(200, 38);
            this.buttonReverseAllSelection.TabIndex = 3;
            this.buttonReverseAllSelection.Text = "選択の切り替え";
            this.buttonReverseAllSelection.UseVisualStyleBackColor = true;
            this.buttonReverseAllSelection.Click += new System.EventHandler(this.ReverseAllSelectionEvent);
            // 
            // buttonExit
            // 
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonExit.Location = new System.Drawing.Point(15, 223);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(200, 38);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "終了";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.FormCloseEvent);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1300, 982);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "履歴の削除";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.contextRegKey.ResumeLayout(false);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel1.PerformLayout();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.flowButton.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonReverseAllSelection;
        private System.Windows.Forms.Button buttonReleaseAllSelection;
        private System.Windows.Forms.Button buttonAllSelect;
        private System.Windows.Forms.FlowLayoutPanel flowButton;
    }
}
