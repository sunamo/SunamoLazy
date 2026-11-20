namespace SunamoLazy.Lazy;

/// <summary>
/// Represents the lazy string type.
/// </summary>
public class LazyString : LazyT<string>
{
    /// <summary>
    /// Initializes a new instance of the lazy string class.
    /// </summary>
    /// <param name="getCommonSettings">The get common settings.</param>
    /// <param name="key">The key.</param>
    public LazyString(Func<string, bool, string> getCommonSettings, string key) : base(getCommonSettings, key)
    {
    }
}
