namespace Core.Mods.Themes
{
    /// <summary>
    /// Интерфейс цветовой темы приложения.
    /// </summary>
    public interface ITheme : IBrushes, ITitleBarIcons
    {
        /// <summary>
        /// Название цветовой темы.
        /// </summary>
        public string Name { get; }
    }
}