using SincUI.Forms;

namespace SincUI.Demo
{
    public partial class MainForm : SincForm
    {
        public MainForm()
        {
            InitializeComponent();

            ThemeManager = ThemeManager.Instance;
            ThemeManager.AddToManager(this);
            ThemeManager.Theme = Theme.LIGHT;
        }
    }
}