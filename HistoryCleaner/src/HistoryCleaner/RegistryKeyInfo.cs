namespace HistoryCleaner
{
    /// <summary>
    /// 対象レジストリキーの情報を表すクラス
    /// </summary>
    public class RegistryKeyInfo
    {
        /// <summary>
        /// レジストリキーの名前
        /// </summary>
        public string KeyName
        {
            get;
            set;
        }

        /// <summary>
        /// レジストリキーの説明
        /// </summary>
        public string Description
        {
            get;
            set;
        }
    }
}
