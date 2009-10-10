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
            this.Font = SystemInformation.MenuFont;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // ���X�g�r���[���N���A����
            listViewRegKey.Items.Clear();

            if (Properties.Settings.Default.TargetKeys != null)
            {
                // �ݒ�t�@�C���̏������X�g�r���[�ɒǉ�����
                foreach (RegistryKeyInfo info in Properties.Settings.Default.TargetKeys)
                {
                    ListViewItem item = new ListViewItem(info.Description);
                    item.SubItems.Add(info.KeyName);
                    listViewRegKey.Items.Add(item);
                }

                // �񕝂�������������
                listViewRegKey.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        /// <summary>
        /// �t�H�[�������C�x���g
        /// </summary>
        private void FormCloseEvent(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// �������s�C�x���g
        /// </summary>
        private void ExecuteEvent(object sender, EventArgs e)
        {
            RegistryKeyFactory factory = RegistryKeyFactory.Instance;
            StringBuilder sb = new StringBuilder();

            foreach (ListViewItem item in listViewRegKey.CheckedItems)
            {
                factory.KeyName = item.SubItems[1].Text;

                try
                {
                    factory.RootKey.DeleteSubKeyTree(factory.SubKeyName);
                    sb.AppendFormat("{0}\\{1} ���폜���܂����B", factory.RootKey.Name, factory.SubKeyName);
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
        /// ���W�X�g���G�f�B�^�N���C�x���g
        /// </summary>
        private void ExecuteRegeditEvent(object sender, EventArgs e)
        {
            try
            {
                Process.Start("regedit.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("���W�X�g���G�f�B�^�N�����ɃG���[���������܂����B",
                                "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// �S�I���C�x���g
        /// </summary>
        private void SelectAllEvent(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewRegKey.Items)
            {
                item.Checked = true;
            }
        }

        /// <summary>
        /// �S�I�������C�x���g
        /// </summary>
        private void ReleaseAllSelectionEvent(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewRegKey.Items)
            {
                item.Checked = false;
            }
        }

        /// <summary>
        /// �S�I��؂�ւ��C�x���g
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