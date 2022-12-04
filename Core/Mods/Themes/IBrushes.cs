using System.Windows.Media;

namespace Core.Mods.Themes
{
    public interface IBrushes
    {
        /// <summary>
        /// Основная кисть фона.
        /// </summary>
        public Brush MainBackground { get; }

        /// <summary>
        /// Дополнительная кисть фона.
        /// </summary>
        public Brush AdditionalBackground { get; }

        /// <summary>
        /// Яркая кисть фона.
        /// </summary>
        public Brush BrgihtBackground { get; }

        /// <summary>
        /// Кисть фона элемента.
        /// </summary>
        public Brush ElementBackground { get; }

        /// <summary>
        /// Кисть фона элемена при наведении мыши.
        /// </summary>
        public Brush CoveredElementBackground { get; }

        /// <summary>
        /// Кисть границы.
        /// </summary>
        public Brush BorderBackground { get; }

        /// <summary>
        /// Кисть границы при наведении мыши.
        /// </summary>
        public Brush CoveredBorderBackground { get; }

        /// <summary>
        /// Основная кисть текста.
        /// </summary>
        public Brush MainForegraund { get; }

        /// <summary>
        /// Кисть текста неработающего элемента.
        /// </summary>
        public Brush DisabledForeground { get; }

        /// <summary>
        /// Болле яркая кисть текста по сравнению с основной кистью.
        /// </summary>
        public Brush BrightForeground { get; }
    }
}