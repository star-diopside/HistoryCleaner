using System;
using Microsoft.Win32;

namespace HistoryCleaner
{
    /// <summary>
    /// レジストリキー名からレジストリ操作に必要なオブジェクトを生成する。
    /// </summary>
    internal class RegistryKeyFactory
    {
        private static RegistryKeyFactory _instance;
        private string _keyName;
        private RegistryKey _rootKey;
        private string _subKeyName;

        /// <summary>
        /// RegistryKeyFactory クラスの新しいインスタンスの初期化を行う。
        /// </summary>
        private RegistryKeyFactory()
        {
            // フィールドの初期化を行う。
            this._keyName = "HKEY_CURRENT_USER";
            this._rootKey = GetRegistryRootKey(this._keyName);
            this._subKeyName = string.Empty;
        }

        /// <summary>
        /// RegistryKeyFactory クラスのインスタンスを取得する。
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
        /// ルートキーを含めたレジストリキー名の取得または設定を行う。
        /// </summary>
        public string KeyName
        {
            get
            {
                return this._keyName;
            }
            set
            {
                // 設定されたキー名からルートの RegistryKey とサブキー名を設定する
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
        /// ルートキーを表す RegistryKey オブジェクトを取得する。
        /// </summary>
        public RegistryKey RootKey
        {
            get
            {
                return this._rootKey;
            }
        }

        /// <summary>
        /// ルートキーを含めないレジストリキー名を取得する。
        /// </summary>
        public string SubKeyName
        {
            get
            {
                return this._subKeyName;
            }
        }

        /// <summary>
        /// ルートキー名から RegistryKey オブジェクトを取得する。
        /// </summary>
        /// <param name="rootKeyName">ルートキー名</param>
        /// <returns>ルートキーを表す RegistryKey オブジェクト</returns>
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
