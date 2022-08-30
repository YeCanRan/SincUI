namespace SincUI.Forms
{
    public class SincForm : Form
    {
        /// <summary>
        /// 主题管理器属性
        /// </summary>
        private ThemeManager? _themeManager;
        public ThemeManager ThemeManager
        {
            get => _themeManager = ThemeManager.Instance;
            set => _themeManager = value;
        }
    }
}