using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryCleaner
{
    class RegistryKeyFactory
    {
        private string _keyName;
        private RegistryKey _rootKey;
        private string _subKeyName;

        public RegistryKeyFactory()
        {
        }

        public string KeyName
        {
            get
            {
                return this._keyName;
            }
            set
            {
                this._keyName = value;

                // 設定されたキー名からルートの RegistryKey とサブキー名を設定する
                if (this._keyName == null)
                {
                    this._rootKey = null;
                    this._subKeyName = null;
                }
                else
                {
                    int index = this._keyName.IndexOf('\\');
                    if (index == -1)
                    {
                        this._rootKey = GetRegistryKey(this._keyName);
                        this._subKeyName = (this._rootKey == null ? null : string.Empty);
                    }
                    else
                    {
                        this._rootKey = GetRegistryKey(this._keyName.Substring(0, index));
                        if (this._rootKey == null)
                        {
                            this._subKeyName = null;
                        }
                        else
                        {
                            while (index < this._keyName.Length && this._keyName[index] == '\\')
                            {
                                index++;
                            }
                            this._subKeyName = this._keyName.Substring(index);
                        }
                    }
                }
            }
        }

        public RegistryKey RootKey
        {
            get
            {
                return this._rootKey;
            }
        }

        public string SubKeyName
        {
            get
            {
                return this._subKeyName;
            }
        }

        public static RegistryKey GetRegistryKey(string rootKeyName)
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
                    key = null;
                    break;
            }

            return key;
        }
    }
}
