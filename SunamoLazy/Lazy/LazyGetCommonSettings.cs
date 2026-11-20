namespace SunamoLazy.Lazy;

/// <summary>
/// Represents the lazy get common settings type.
/// </summary>
public class LazyGetCommonSettings : LazyString
{
    /// <summary>
    /// Initializes a new instance of the lazy get common settings class.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="appDataGetCommonSettings">The app data get common settings.</param>
    public LazyGetCommonSettings(string key, Func<string, bool, string> appDataGetCommonSettings) : base(appDataGetCommonSettings, key)
    {
    }
}
