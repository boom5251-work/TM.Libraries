using System.Windows.Media.Imaging;

namespace Core.Mods.Themes
{
    /// <summary>
    /// Иконки шапки окна.
    /// </summary>
    public interface ITitleBarIcons
    {
        /// <summary>
        /// Иконка "закрыть".
        /// </summary>
        public BitmapImage CloseIcon { get; }

        /// <summary>
        /// Иконка "во весь экран".
        /// </summary>
        public BitmapImage MaximizeIcon { get; }

        /// <summary>
        /// Иконка "свернуть".
        /// </summary>
        public BitmapImage MinimizeIcon { get; }

        /// <summary>
        /// Иконка "нормальный размер".
        /// </summary>
        public BitmapImage NormalizeIcon { get; }
    }
}