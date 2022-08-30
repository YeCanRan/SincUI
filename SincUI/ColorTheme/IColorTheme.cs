namespace SincUI.ColorTheme
{
    public interface IColorTheme
    {
        /// <summary>
        /// 主题色
        /// </summary>
        public Color PRIMARY_DARKER { get; set; }

        public Color PRIMARY_DARK { get; set; }

        public Color PRIMARY { get; set; }

        public Color PRIMARY_LIGHT { get; set; }

        public Color PRIMARY_LIGHTER { get; set; }

        public Color PRIMARY_LIGHTEST { get; set; }

        /// <summary>
        /// 成功色
        /// </summary>
        public Color SUCCESS_DARKER { get; set; }

        public Color SUCCESS_DARK { get; set; }

        public Color SUCCESS { get; set; }

        public Color SUCCESS_LIGHT { get; set; }

        public Color SUCCESS_LIGHTER { get; set; }

        public Color SUCCESS_LIGHTEST { get; set; }

        /// <summary>
        /// 警告色
        /// </summary>
        public Color WARNING_DARKER { get; set; }

        public Color WARNING_DARK { get; set; }

        public Color WARNING { get; set; }

        public Color WARNING_LIGHT { get; set; }

        public Color WARNING_LIGHTER { get; set; }

        public Color WARNING_LIGHTEST { get; set; }

        /// <summary>
        /// 危险色
        /// </summary>
        public Color DANGER_DARKER { get; set; }

        public Color DANGER_DARK { get; set; }

        public Color DANGER { get; set; }

        public Color DANGER_LIGHT { get; set; }

        public Color DANGER_LIGHTER { get; set; }

        public Color DANGER_LIGHTEST { get; set; }

        /// <summary>
        /// 信息色
        /// </summary>
        public Color INFO_DARKER { get; set; }

        public Color INFO_DARK { get; set; }

        public Color INFO { get; set; }

        public Color INFO_LIGHT { get; set; }

        public Color INFO_LIGHTER { get; set; }

        public Color INFO_LIGHTEST { get; set; }

        /// <summary>
        /// 边框色
        /// </summary>
        public Color BORDER_DARKER { get; set; }

        public Color BORDER_DARK { get; set; }

        public Color BORDER { get; set; }

        public Color BORDER_LIGHT { get; set; }

        public Color BORDER_LIGHTER { get; set; }

        public Color BORDER_LIGHTEST { get; set; }

        /// <summary>
        /// 填充色
        /// </summary>
        public Color FILL_DARKER { get; set; }

        public Color FILL_DARK { get; set; }

        public Color FILL { get; set; }

        public Color FILL_LIGHT { get; set; }

        public Color FILL_LIGHTER { get; set; }

        public Color FILL_LIGHTEST { get; set; }

        /// <summary>
        /// 文本色
        /// </summary>
        public Color TEXT_DARKER { get; set; }

        public Color TEXT_DARK { get; set; }

        public Color TEXT { get; set; }

        public Color TEXT_LIGHT { get; set; }

        public Color TEXT_LIGHTER { get; set; }

        public Color TEXT_LIGHTEST { get; set; }

        /// <summary>
        /// 背景色
        /// </summary>
        public Color BACKGROUND_DARK { get; set; }

        public Color BACKGROUND { get; set; }

        public Color BACKGROUND_LIGHT { get; set; }
    }
}