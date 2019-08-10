using HistoryCleaner.Utility;
using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace HistoryCleaner.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Font = SystemInformation.MenuFont;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // リストビューをクリアする
            listViewRegKey.Items.Clear();

            if (Properties.Settings.Default.TargetKeys != null)
            {
                // 設定ファイルの情報をリストビューに追加する
                foreach (RegistryKeyInfo info in Properties.Settings.Default.TargetKeys)
                {
                    ListViewItem item = new ListViewItem(info.Description);
                    item.SubItems.Add(info.KeyName);
                    listViewRegKey.Items.Add(item);
                }

                // 列幅を自動調整する
                listViewRegKey.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        /// <summary>
        /// フォームを閉じるイベント
        /// </summary>
        private void FormCloseEvent(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 処理実行イベント
        /// </summary>
        private void ExecuteEvent(object sender, EventArgs e)
        {
            var factory = new RegistryKeyFactory();
            var sb = new StringBuilder();

            foreach (ListViewItem item in listViewRegKey.CheckedItems)
            {
                factory.KeyName = item.SubItems[1].Text;

                try
                {
                    factory.RootKey.DeleteSubKeyTree(factory.SubKeyName);
                    sb.AppendFormat("{0}\\{1} を削除しました。", factory.RootKey.Name, factory.SubKeyName);
                }
                catch (Exception ex)
                {
                    sb.AppendFormat("{0} : {1}\\{2}", ex.Message, factory.RootKey.Name, factory.SubKeyName);
                }
                sb.AppendLine();
            }

            textLog.Text = sb.ToString();
        }

        /// <summary>
        /// レジストリエディタ起動イベント
        /// </summary>
        private void ExecuteRegeditEvent(object sender, EventArgs e)
        {
            try
            {
                using var process = new Process();
                process.StartInfo.FileName = "regedit.exe";
                process.StartInfo.UseShellExecute = true;
                process.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("レジストリエディタ起動時にエラーが発生しました。",
                                "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 全選択イベント
        /// </summary>
        private void SelectAllEvent(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewRegKey.Items)
            {
                item.Checked = true;
            }
        }

        /// <summary>
        /// 全選択解除イベント
        /// </summary>
        private void ReleaseAllSelectionEvent(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewRegKey.Items)
            {
                item.Checked = false;
            }
        }

        /// <summary>
        /// 全選択切り替えイベント
        /// </summary>
        private void ReverseAllSelectionEvent(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewRegKey.Items)
            {
                item.Checked = !item.Checked;
            }
        }
    }
}