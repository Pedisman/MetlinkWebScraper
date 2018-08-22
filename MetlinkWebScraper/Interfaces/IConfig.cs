namespace MetlinkWebScraper.Interfaces
{
    /// <summary>
    /// Interface used to abstract away config source (Config file, database etc) probably overkill for this simple project
    /// </summary>
    public interface IConfig
    {
        string ServiceCode { get; }
    }
}
