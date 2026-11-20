namespace SunamoLazy.Lazy;

/// <summary>
/// Represents the lazy t t type.
/// </summary>
public class LazyT<T>
{
    private Func<string, bool, T> getCommonSettings;
    private string argument;
    T? value = default;

    /// <summary>
    /// The value.
    /// </summary>
    public T Value
    {
        get
        {
            if (EqualityComparer<T>.Default.Equals(value, default))
            {
                value = getCommonSettings(argument, true);
            }
            return value!;
        }
    }

    /// <summary>
    /// Lazy t.
    /// </summary>
    /// <param name="getCommonSettings">The get common settings.</param>
    /// <param name="key">The key.</param>
    /// <returns>The lazy t result.</returns>
    public LazyT(Func<string, bool, T> getCommonSettings, string key)
    {
        this.getCommonSettings = getCommonSettings;
        argument = key;
    }
}
