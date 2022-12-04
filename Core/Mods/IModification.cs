using Core.Mods.Themes;
using System.Collections.Generic;

namespace Core.Mods
{
    /// <summary>
    /// Интерфейс модификации приложения.
    /// </summary>
    public interface IModification
    {
        /// <summary>
        /// Название модификации.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Описание модификации.
        /// </summary>
        public string Description { get; }



        /// <summary>
        /// Возвращает пользовательские темы приложения.
        /// </summary>
        /// <returns>Список словарей ресурсов с темой приложения.</returns>
        public virtual List<ITheme> GetThemes() => new();
    }
}