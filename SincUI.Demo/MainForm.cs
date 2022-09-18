using SincUI.Forms;

namespace SincUI.Demo
{
    public partial class MainForm : SincForm
    {
        public MainForm()
        {
            InitializeComponent();

            //将窗口添加到主题管理器
            ThemeManager = ThemeManager.Instance;
            ThemeManager.AddToManager(this);
            ThemeManager.Theme = Theme.LIGHT;

            //模拟窗体初始化
            SincSplasher.Message = "少女折寿中...";
            Thread.Sleep(500);
            SincSplasher.Message = "加载模拟完毕...";
            Thread.Sleep(500);
            SincSplasher.Close();
        }
    }
}