namespace SincUI.Forms
{
    public class SincSplash : Form
    {
        /// <summary>
        /// 重写OnPaint方法
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            base.OnPaint(e);
        }

        /// <summary>
        /// 主窗体如果想传输进度消息给新启动页窗体就在新启动页窗体重写此方法
        /// </summary>
        /// <param name="message"></param>
        public virtual void SendMessage(string message)
        {
        }
    }
}