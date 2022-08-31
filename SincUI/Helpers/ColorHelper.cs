namespace SincUI.Helpers
{
    public class ColorHelper
    {
        private struct Rgb
        {
            /// <summary>
            /// 红
            /// </summary>
            public int R { get; set; }

            /// <summary>
            /// 绿
            /// </summary>
            public int G { get; set; }

            /// <summary>
            /// 蓝
            /// </summary>
            public int B { get; set; }
        }

        private struct Hsv
        {
            /// <summary>
            /// 色相
            /// </summary>
            public int H { get; set; }

            /// <summary>
            /// 饱和度
            /// </summary>
            public int S { get; set; }

            /// <summary>
            /// 明度
            /// </summary>
            public int V { get; set; }
        }

        /// <summary>
        /// 根据RGB值获取对应的不透明颜色对象，建议使用16进制
        /// </summary>
        /// <param name="rgb">RGB值</param>
        /// <returns>对应的不透明颜色对象</returns>
        public static Color FromRgb(int rgb)
        {
            return Color.FromArgb(rgb / (256 * 256), rgb / 256 % 256, rgb % 256);
        }

        /// <summary>
        /// 加更深的颜色
        /// </summary>
        /// <param name="color">原色</param>
        /// <returns>加深后的颜色</returns>
        public static Color ToDarker(Color color)
        {
            var hsv = RgbToHsv(new Rgb() { R = color.R, G = color.G, B = color.B });
            hsv.V = hsv.V > 20 ? hsv.V - 20 : 0;
            var rgb = HsvToRgb(hsv);
            return Color.FromArgb(rgb.R, rgb.G, rgb.B);
        }

        /// <summary>
        /// 加深的颜色
        /// </summary>
        /// <param name="color">原色</param>
        /// <returns>加深后的颜色</returns>
        public static Color ToDark(Color color)
        {
            var hsv = RgbToHsv(new Rgb() { R = color.R, G = color.G, B = color.B });
            hsv.V = hsv.V > 10 ? hsv.V - 10 : 0;
            var rgb = HsvToRgb(hsv);
            return Color.FromArgb(rgb.R, rgb.G, rgb.B);
        }

        /// <summary>
        /// 提浅的颜色
        /// </summary>
        /// <param name="color">原色</param>
        /// <returns>提浅后的颜色</returns>
        public static Color ToLight(Color color)
        {
            var hsv = RgbToHsv(new Rgb() { R = color.R, G = color.G, B = color.B });
            hsv.S = hsv.S > 20 ? hsv.S - 20 : 0;
            hsv.V = hsv.V > 90 ? 100 : hsv.V + 10;
            var rgb = HsvToRgb(hsv);
            return Color.FromArgb(rgb.R, rgb.G, rgb.B);
        }

        /// <summary>
        /// 提更浅的颜色
        /// </summary>
        /// <param name="color">原色</param>
        /// <returns>提浅后的颜色</returns>
        public static Color ToLighter(Color color)
        {
            var hsv = RgbToHsv(new Rgb() { R = color.R, G = color.G, B = color.B });
            hsv.S = hsv.S > 40 ? hsv.S - 40 : 0;
            hsv.V = hsv.V > 80 ? 100 : hsv.V + 20;
            var rgb = HsvToRgb(hsv);
            return Color.FromArgb(rgb.R, rgb.G, rgb.B);
        }

        /// <summary>
        /// 提最浅的颜色
        /// </summary>
        /// <param name="color">原色</param>
        /// <returns>提浅后的颜色</returns>
        public static Color ToLightest(Color color)
        {
            var hsv = RgbToHsv(new Rgb() { R = color.R, G = color.G, B = color.B });
            hsv.S -= 60;
            var rgb = HsvToRgb(hsv);
            return Color.FromArgb(rgb.R, rgb.G, rgb.B);
        }

        /// <summary>
        /// 将RGB色彩空间转换为HSV色彩空间
        /// </summary>
        /// <param name="rgb">RGB结构体</param>
        /// <returns>HSV结构体</returns>
        private static Hsv RgbToHsv(Rgb rgb)
        {
            Hsv hsv = new();
            float r = rgb.R / 255f;
            float g = rgb.G / 255f;
            float b = rgb.B / 255f;
            float max = Math.Max(Math.Max(r, g), b);
            float min = Math.Min(Math.Min(r, g), b);
            float delta = max - min;
            if (max == min)
            {
                hsv.H = 0;
            }
            else if (max == r && g >= b)
            {
                hsv.H = (int)Math.Round(60 * (g - b) / delta);
            }
            else if (max == r && g < b)
            {
                hsv.H = (int)Math.Round(60 * (g - b) / delta + 360);
            }
            else if (max == g)
            {
                hsv.H = (int)Math.Round(60 * (b - r) / delta + 120);
            }
            else
            {
                hsv.H = (int)Math.Round(60 * (r - g) / delta + 240);
            }
            hsv.S = max == 0 ? 0 : (int)Math.Round(delta / max * 100);
            hsv.V = (int)Math.Round(max * 100);
            return hsv;
        }

        /// <summary>
        /// 将HSV色彩空间转换为RGB色彩空间
        /// </summary>
        /// <param name="hsv">HSV结构体</param>
        /// <returns>RGB结构体</returns>
        private static Rgb HsvToRgb(Hsv hsv)
        {
            Rgb rgb = new();
            float c, x, y, z, i;
            float h = hsv.H;
            float s = hsv.S / 100f;
            float v = hsv.V / 100f;
            if (s == 0)
            {
                rgb.R = rgb.G = rgb.B = (int)Math.Round(v * 255);
            }
            else
            {
                h /= 60;
                i = (int)h;
                c = h - i;
                x = v * (1 - s);
                y = v * (1 - s * c);
                z = v * (1 - s * (1 - c));
                switch (i)
                {
                    case 0:
                        rgb.R = (int)Math.Round(v * 100);
                        rgb.G = (int)Math.Round(z * 100);
                        rgb.B = (int)Math.Round(x * 100);
                        break;
                    case 1:
                        rgb.R = (int)Math.Round(y * 100);
                        rgb.G = (int)Math.Round(v * 100);
                        rgb.B = (int)Math.Round(x * 100);
                        break;
                    case 2:
                        rgb.R = (int)Math.Round(x * 100);
                        rgb.G = (int)Math.Round(v * 100);
                        rgb.B = (int)Math.Round(z * 100);
                        break;
                    case 3:
                        rgb.R = (int)Math.Round(x * 100);
                        rgb.G = (int)Math.Round(y * 100);
                        rgb.B = (int)Math.Round(v * 100);
                        break;
                    case 4:
                        rgb.R = (int)Math.Round(z * 100);
                        rgb.G = (int)Math.Round(x * 100);
                        rgb.B = (int)Math.Round(v * 100);
                        break;
                    case 5:
                        rgb.R = (int)Math.Round(v * 100);
                        rgb.G = (int)Math.Round(x * 100);
                        rgb.B = (int)Math.Round(y * 100);
                        break;
                    default:
                        break;
                }
            }
            return rgb;
        }
    }
}