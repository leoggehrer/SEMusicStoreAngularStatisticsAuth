//@CodeCopy
namespace SEMusicStoreAngularStatisticsAuth.Common.Contracts
{
    public partial interface ISettings
    {
        string? this[string key] { get; }
    }
}
