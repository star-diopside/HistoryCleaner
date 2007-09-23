using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace HistoryCleaner
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FormClose(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            RegistryKeyFactory factory = RegistryKeyFactory.Instance;
            StringBuilder sb = new StringBuilder();

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

        private void ExecuteRegedit(object sender, EventArgs e)
        {
            try
            {
                Process.Start("regedit.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("レジストリエディタ起動時にエラーが発生しました。",
                                "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuAllSelect_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewRegKey.Items)
            {
                item.Checked = true;
            }
        }

        private void menuReleaseAllSelection_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewRegKey.Items)
            {
                item.Checked = false;
            }
        }

        private void menuReverseAllSelection_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewRegKey.Items)
            {
                item.Checked = !item.Checked;
            }
        }
    }
}