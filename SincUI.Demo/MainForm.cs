using SincUI.Forms;

namespace SincUI.Demo
{
    public partial class MainForm : SincForm
    {
        public MainForm()
        {
            InitializeComponent();

            //��������ӵ����������
            ThemeManager = ThemeManager.Instance;
            ThemeManager.AddToManager(this);
            ThemeManager.Theme = Theme.LIGHT;

            //ģ�ⴰ���ʼ��
            SincSplasher.Message = "��Ů������...";
            Thread.Sleep(500);
            SincSplasher.Message = "����ģ�����...";
            Thread.Sleep(500);
            SincSplasher.Close();
        }
    }
}