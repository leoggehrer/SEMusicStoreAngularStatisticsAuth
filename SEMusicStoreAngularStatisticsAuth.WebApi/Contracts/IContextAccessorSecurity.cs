//@CodeCopy
#if ACCOUNT_ON
namespace SEMusicStoreAngularStatisticsAuth.WebApi.Contracts
{
    partial interface IContextAccessor
    {
        string SessionToken { set; }
    }
}
#endif
