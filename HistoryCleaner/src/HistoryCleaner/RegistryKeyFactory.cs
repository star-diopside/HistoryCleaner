using System;
using Microsoft.Win32;

namespace HistoryCleaner
{
    /// <summary>
    /// ���W�X�g���L�[�����烌�W�X�g������ɕK�v�ȃI�u�W�F�N�g�𐶐�����B
    /// </summary>
    internal class RegistryKeyFactory
    {
        private static RegistryKeyFactory _instance;
        private string _keyName;
        private RegistryKey _rootKey;
        private string _subKeyName;

        /// <summary>
        /// RegistryKeyFactory �N���X�̐V�����C���X�^���X�̏��������s���B
        /// </summary>
        private RegistryKeyFactory()
        {
            // �t�B�[���h�̏��������s���B
            this._keyName = "HKEY_CURRENT_USER";
            this._rootKey = GetRegistryRootKey(this._keyName);
            this._subKeyName = string.Empty;
        }

        /// <summary>
        /// RegistryKeyFactory �N���X�̃C���X�^���X���擾����B
        /// </summary>
        public static RegistryKeyFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RegistryKeyFactory();
                }
                return _instance;
            }
        }

        /// <summary>
        /// ���[�g�L�[���܂߂����W�X�g���L�[���̎擾�܂��͐ݒ���s���B
        /// </summary>
        public string KeyName
        {
            get
            {
                return this._keyName;
            }
            set
            {
                // �ݒ肳�ꂽ�L�[�����烋�[�g�� RegistryKey �ƃT�u�L�[����ݒ肷��
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    int index = value.IndexOf('\\');

                    if (index == -1)
                    {
                        this._rootKey = GetRegistryRootKey(value);
                        this._subKeyName = string.Empty;
                    }
                    else
                    {
                        this._rootKey = GetRegistryRootKey(value.Substring(0, index));
                        while (index < value.Length && value[index] == '\\')
                        {
                            index++;
                        }
                        this._subKeyName = value.Substring(index);
                    }

                    this._keyName = value;
                }
            }
        }

        /// <summary>
        /// ���[�g�L�[��\�� RegistryKey �I�u�W�F�N�g���擾����B
        /// </summary>
        public RegistryKey RootKey
        {
            get
            {
                return this._rootKey;
            }
        }

        /// <summary>
        /// ���[�g�L�[���܂߂Ȃ����W�X�g���L�[�����擾����B
        /// </summary>
        public string SubKeyName
        {
            get
            {
                return this._subKeyName;
            }
        }

        /// <summary>
        /// ���[�g�L�[������ RegistryKey �I�u�W�F�N�g���擾����B
        /// </summary>
        /// <param name="rootKeyName">���[�g�L�[��</param>
        /// <returns>���[�g�L�[��\�� RegistryKey �I�u�W�F�N�g</returns>
        private static RegistryKey GetRegistryRootKey(string rootKeyName)
        {
            RegistryKey key;

            switch (rootKeyName)
            {
                case "HKEY_CURRENT_USER":
                    key = Registry.CurrentUser;
                    break;

                case "HKEY_LOCAL_MACHINE":
                    key = Registry.LocalMachine;
                    break;

                case "HKEY_CLASSES_ROOT":
                    key = Registry.ClassesRoot;
                    break;

                case "HKEY_USERS":
                    key = Registry.Users;
                    break;

                case "HKEY_PERFORMANCE_DATA":
                    key = Registry.PerformanceData;
                    break;

                case "HKEY_CURRENT_CONFIG":
                    key = Registry.CurrentConfig;
                    break;

                case "HKEY_DYN_DATA":
                    key = Registry.DynData;
                    break;

                default:
                    throw new ArgumentException();
            }

            return key;
        }
    }
}
