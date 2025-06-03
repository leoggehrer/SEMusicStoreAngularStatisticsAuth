//@CodeCopy
#if ACCOUNT_ON
using SEMusicStoreAngularStatisticsAuth.WebApi.Contracts;

namespace SEMusicStoreAngularStatisticsAuth.WebApi.Controllers
{
    partial class GenericViewController<TModel, TView, TContract>
    {
        #region partial methods
        partial void OnReadContextAccessor(IContextAccessor contextAccessor)
        {
            contextAccessor.SessionToken = SessionToken;
        }
        #endregion partial methods
    }
}
#endif
