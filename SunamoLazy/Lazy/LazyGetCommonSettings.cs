namespace SunamoLazy.Lazy;

public class LazyGetCommonSettings : LazyString
{
    public LazyGetCommonSettings(string key, Func<string, bool, string> appDataGetCommonSettings) : base(appDataGetCommonSettings, key)
    {
    }
}
