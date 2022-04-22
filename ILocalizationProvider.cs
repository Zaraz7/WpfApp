namespace WPFLocalizeExtension.Providers
{
    #region Usings
    using System.Collections.ObjectModel;
    using System.Globalization;
    using System.Windows;
    #endregion

    public interface ILocalizationProvider
    {
        FullyQualifiedResourceKeyBase GetFullyQualifiedResourceKey(string key, DependencyObject target);

        /// <summary>
        /// Get the localized object.
        /// </summary>
        /// <param name="key">The key to the value.</param>
        /// <param name="target">The target <see cref="DependencyObject"/>.</param>
        /// <param name="culture">The culture to use.</param>
        /// <returns>The value corresponding to the source/dictionary/key path for the given culture (otherwise NULL).</returns>
        object GetLocalizedObject(string key, DependencyObject target, CultureInfo culture);

        /// <summary>
        /// An observable list of available cultures.
        /// </summary>
        ObservableCollection<CultureInfo> AvailableCultures { get; }

        /// <summary>
        /// An event that is fired when the provider changed.
        /// </summary>
        event ProviderChangedEventHandler ProviderChanged;

        /// <summary>
        /// An event that is fired when an error occurred.
        /// </summary>
        event ProviderErrorEventHandler ProviderError;

        /// <summary>
        /// An event that is fired when a value changed.
        /// </summary>
        event ValueChangedEventHandler ValueChanged;
    }
}
