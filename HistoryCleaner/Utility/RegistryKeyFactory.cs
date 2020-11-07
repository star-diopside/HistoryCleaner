using Microsoft.Win32;
using System;
using System.Diagnostics.CodeAnalysis;

namespace HistoryCleaner.Utility
{
    /// <summary>
    /// レジストリキー名からレジストリ操作に必要なオブジェクトを生成する。
    /// </summary>
    internal class RegistryKeyFactory
    {
        private string? _keyName;

        /// <summary>
        /// ルートキーを含めたレジストリキー名の取得または設定を行う。
        /// </summary>
        [DisallowNull]
        public string? KeyName
        {
            get => _keyName;

            [MemberNotNull(nameof(RootKey), nameof(SubKeyName))]
            set
            {
                // 設定されたキー名からルートの RegistryKey とサブキー名を設定する
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
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

                _keyName = value;
            }
        }

        /// <summary>
        /// ルートキーを表す RegistryKey オブジェクトを取得する。
        /// </summary>
        public RegistryKey? RootKey { get; private set; }

        /// <summary>
        /// ルートキーを含めないレジストリキー名を取得する。
        /// </summary>
        public string? SubKeyName { get; private set; }

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
            _ => throw new ArgumentException("Not Found RegistryKey: " + rootKeyName, nameof(rootKeyName))
        };
    }
}
