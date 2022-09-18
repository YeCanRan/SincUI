namespace SincUI.Forms
{
    public class SincSplasher
    {
        /// <summary>
        /// 启动页线程
        /// </summary>
        private static Thread? _splashThread;

        private static SincSplash? _splash;

        /// <summary>
        /// 消息属性
        /// </summary>
        private static string _message = string.Empty;
        public static string Message
        {
            set
            {
                if (_splash is null)
                {
                    _message = value;
                    return;
                }
                if (_splash.IsHandleCreated)
                {
                    _splash.Invoke(new Splash_MessageChanged(delegate (string message) { _splash.SendMessage(message); }), new object[] { value });
                }
            }
        }

        private delegate void Splash_MessageChanged(string message);

        /// <summary>
        /// 展示启动页
        /// </summary>
        /// <param name="type"></param>
        public static void Show(Type type)
        {
            if (_splashThread is not null)
            {
                return;
            }
            _splashThread = new Thread(new ThreadStart(delegate ()
            {
                _splash = Activator.CreateInstance(type) as SincSplash;
                _splash?.SendMessage(_message);
                Application.Run(_splash);
            }));
            _splashThread.Start();
        }

        /// <summary>
        /// 关闭启动页
        /// </summary>
        public static void Close()
        {
            if (_splash is null)
            {
                return;
            }
            _splash.Invoke(new MethodInvoker(_splash.Close));
            _splash.Dispose();
        }
    }
}