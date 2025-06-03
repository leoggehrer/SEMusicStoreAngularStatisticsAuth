//@CodeCopy
#if ACCOUNT_ON
namespace SEMusicStoreAngularStatisticsAuth.Logic.Contracts
{
    partial interface IContext
    {
        #region properties
        /// <summary>
        /// Sets the session token.
        /// </summary>
        string SessionToken { set; }
        #endregion properties
    }
}
#endif
