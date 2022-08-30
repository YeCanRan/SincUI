using SincUI.ColorTheme;
using SincUI.Forms;

namespace SincUI
{
    public enum Theme { LIGHT, DARK }

    public class ThemeManager
    {
        /// <summary>
        /// 主题管理器属性
        /// </summary>
        private static ThemeManager? _instance;
        public static ThemeManager Instance => _instance ??= new ThemeManager();

        /// <summary>
        /// 主题属性
        /// </summary>
        private Theme _theme;
        public Theme Theme
        {
            get
            {
                return _theme;
            }
            set
            {
                _theme = value;
                UpdateTheme();
            }
        }

        /// <summary>
        /// 窗口集合
        /// </summary>
        private readonly List<SincForm> _forms = new();

        /// <summary>
        /// 将窗体添加进主题管理器
        /// </summary>
        /// <param name="form">窗体</param>
        public void AddToManager(SincForm form)
        {
            _forms.Add(form);

            //更新主题
            UpdateTheme();
        }

        /// <summary>
        /// 更新主题
        /// </summary>
        private void UpdateTheme()
        {
            IColorTheme theme = Theme == Theme.LIGHT ? new LightTheme() : new DarkTheme();
            foreach (SincForm form in _forms)
            {
                form.BackColor = theme.BACKGROUND_LIGHT;
                UpdateControl(form, theme);
            }
        }

        /// <summary>
        /// 更新控件的主题
        /// </summary>
        /// <param name="control">控件</param>
        /// <param name="theme">主题</param>
        private static void UpdateControl(Control controlToUpdate, IColorTheme theme)
        {
            if (controlToUpdate is null)
            {
                return;
            }

            if (controlToUpdate.ContextMenuStrip is not null)
            {
                UpdateToolStrip(controlToUpdate.ContextMenuStrip, theme);
            }

            //递归调用，更新下级控件
            foreach (Control control in controlToUpdate.Controls)
            {
                UpdateControl(control, theme);
            }

            controlToUpdate.Invalidate();
        }

        /// <summary>
        /// 更新工具栏类控件的主题
        /// </summary>
        /// <param name="toolStrip">工具栏类控件</param>
        /// <param name="theme">主题</param>
        private static void UpdateToolStrip(ToolStrip toolStripToUpdate, IColorTheme theme)
        {
            if (toolStripToUpdate is null)
            {
                return;
            }

            toolStripToUpdate.BackColor = theme.BACKGROUND_LIGHT;

            foreach (ToolStripItem toolStripItem in toolStripToUpdate.Items)
            {
                toolStripItem.BackColor = theme.BACKGROUND_LIGHT;
            }
        }
    }
}