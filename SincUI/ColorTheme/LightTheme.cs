using SincUI.Helpers;

namespace SincUI.ColorTheme
{
    public class LightTheme : IColorTheme
    {
        private static readonly Color _primary = ColorHelper.FromRgb(0x005FB7);
        private static readonly Color _success = ColorHelper.FromRgb(0x0F7B0F);
        private static readonly Color _warning = ColorHelper.FromRgb(0x9D5D00);
        private static readonly Color _danger = ColorHelper.FromRgb(0xC42B1C);
        private static readonly Color _info = ColorHelper.FromRgb(0x8A8A8A);
        private static readonly Color _border = ColorHelper.FromRgb(0xAFAFAF);
        private static readonly Color _fill = ColorHelper.FromRgb(0xF2F2F2);
        private static readonly Color _text = ColorHelper.FromRgb(0x4F4F4F);
        private static readonly Color _background = ColorHelper.FromRgb(0xE6E6E6);

        public Color PRIMARY_DARKER { get; set; } = ColorHelper.ToDarker(_primary);
        public Color PRIMARY_DARK { get; set; } = ColorHelper.ToDark(_primary);
        public Color PRIMARY { get; set; } = _primary;
        public Color PRIMARY_LIGHT { get; set; } = ColorHelper.ToLight(_primary);
        public Color PRIMARY_LIGHTER { get; set; } = ColorHelper.ToLighter(_primary);
        public Color PRIMARY_LIGHTEST { get; set; } = ColorHelper.ToLightest(_primary);

        public Color SUCCESS_DARKER { get; set; } = ColorHelper.ToDarker(_success);
        public Color SUCCESS_DARK { get; set; } = ColorHelper.ToDark(_success);
        public Color SUCCESS { get; set; } = _success;
        public Color SUCCESS_LIGHT { get; set; } = ColorHelper.ToLight(_success);
        public Color SUCCESS_LIGHTER { get; set; } = ColorHelper.ToLighter(_success);
        public Color SUCCESS_LIGHTEST { get; set; } = ColorHelper.ToLightest(_success);

        public Color WARNING_DARKER { get; set; } = ColorHelper.ToDarker(_warning);
        public Color WARNING_DARK { get; set; } = ColorHelper.ToDark(_warning);
        public Color WARNING { get; set; } = _warning;
        public Color WARNING_LIGHT { get; set; } = ColorHelper.ToLight(_warning);
        public Color WARNING_LIGHTER { get; set; } = ColorHelper.ToLighter(_warning);
        public Color WARNING_LIGHTEST { get; set; } = ColorHelper.ToLightest(_warning);

        public Color DANGER_DARKER { get; set; } = ColorHelper.ToDarker(_danger);
        public Color DANGER_DARK { get; set; } = ColorHelper.ToDark(_danger);
        public Color DANGER { get; set; } = _danger;
        public Color DANGER_LIGHT { get; set; } = ColorHelper.ToLight(_danger);
        public Color DANGER_LIGHTER { get; set; } = ColorHelper.ToLighter(_danger);
        public Color DANGER_LIGHTEST { get; set; } = ColorHelper.ToLightest(_danger);

        public Color INFO_DARKER { get; set; } = ColorHelper.ToDarker(_info);
        public Color INFO_DARK { get; set; } = ColorHelper.ToDark(_info);
        public Color INFO { get; set; } = _info;
        public Color INFO_LIGHT { get; set; } = ColorHelper.ToLight(_info);
        public Color INFO_LIGHTER { get; set; } = ColorHelper.ToLighter(_info);
        public Color INFO_LIGHTEST { get; set; } = ColorHelper.ToLightest(_info);

        public Color BORDER_DARKER { get; set; } = ColorHelper.ToDarker(_border);
        public Color BORDER_DARK { get; set; } = ColorHelper.ToDark(_border);
        public Color BORDER { get; set; } = _border;
        public Color BORDER_LIGHT { get; set; } = ColorHelper.ToLight(_border);
        public Color BORDER_LIGHTER { get; set; } = ColorHelper.ToLighter(_border);
        public Color BORDER_LIGHTEST { get; set; } = ColorHelper.ToLightest(_border);

        public Color FILL_DARKER { get; set; } = ColorHelper.ToDarker(_fill);
        public Color FILL_DARK { get; set; } = ColorHelper.ToDark(_fill);
        public Color FILL { get; set; } = _fill;
        public Color FILL_LIGHT { get; set; } = ColorHelper.ToLight(_fill);
        public Color FILL_LIGHTER { get; set; } = ColorHelper.ToLighter(_fill);
        public Color FILL_LIGHTEST { get; set; } = ColorHelper.ToLightest(_fill);

        public Color TEXT_DARKER { get; set; } = ColorHelper.ToDarker(_text);
        public Color TEXT_DARK { get; set; } = ColorHelper.ToDark(_text);
        public Color TEXT { get; set; } = _text;
        public Color TEXT_LIGHT { get; set; } = ColorHelper.ToLight(_text);
        public Color TEXT_LIGHTER { get; set; } = ColorHelper.ToLighter(_text);
        public Color TEXT_LIGHTEST { get; set; } = ColorHelper.ToLightest(_text);

        public Color BACKGROUND_DARK { get; set; } = ColorHelper.ToDark(_background);
        public Color BACKGROUND { get; set; } = _background;
        public Color BACKGROUND_LIGHT { get; set; } = ColorHelper.ToLight(_background);
    }
}