using Microsoft.Win32;
using System;

namespace HistoryCleaner.Utility
{
    /// <summary>
    /// レジストリキー名からレジストリ操作に必要なオブジェクトを生成する。
    /// </summary>
    internal class RegistryKeyFactory
    {
        private string _keyName;

        /// <summary>
        /// RegistryKeyFactory クラスの新しいインスタンスの初期化を行う。
        /// </summary>
        internal RegistryKeyFactory()
        {
            // フィールドの初期化を行う。
            this._keyName = "HKEY_CURRENT_USER";
            this.RootKey = GetRegistryRootKey(this._keyName);
            this.SubKeyName = string.Empty;
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

                int index = value.IndexOf('\\');

                if (index == -1)
                {
                    this.RootKey = GetRegistryRootKey(value);
                    this.SubKeyName = string.Empty;
                }
                else
                {
                    this.RootKey = GetRegistryRootKey(value.Substring(0, index));
                    while (index < value.Length && value[index] == '\\')
                    {
                        index++;
                    }
                    this.SubKeyName = value.Substring(index);
                }

                this._keyName = value;
            }
        }

        /// <summary>
        /// ルートキーを表す RegistryKey オブジェクトを取得する。
        /// </summary>
        public RegistryKey RootKey { get; private set; }

        /// <summary>
        /// ルートキーを含めないレジストリキー名を取得する。
        /// </summary>
        public string SubKeyName { get; private set; }

        /// <summary>
        /// ルートキー名から RegistryKey オブジェクトを取得する。
        /// </summary>
        /// <param name="rootKeyName">ルートキー名</param>
        /// <returns>ルートキーを表す RegistryKey オブジェクト</returns>
        private static RegistryKey GetRegistryRootKey(string rootKeyName) => rootKeyName switch
        {
            "HKEY_CURRENT_USER" => Registry.CurrentUser,
            "HKEY_LOCAL_MACHINE" => Registry.LocalMachine,
            "HKEY_CLASSES_ROOT" => Registry.ClassesRoot,
            "HKEY_USERS" => Registry.Users,
            "HKEY_PERFORMANCE_DATA" => Registry.PerformanceData,
            "HKEY_CURRENT_CONFIG" => Registry.CurrentConfig,
            _ => throw new ArgumentException()
        };
    }
}
