#if GENERATEDCODE_ON
using SEMusicStoreAngularStatisticsAuth.Logic.Entities;
using SEMusicStoreAngularStatisticsAuth.Logic.Modules.Security;
using System.Reflection;

namespace SEMusicStoreAngularStatisticsAuth.Logic.DataContext
{
    [Authorize("SysAdmin", "AppAdmin", "AppManager")]
    partial class GenreSet
    {
        [Authorize("SysAdmin", "AppAdmin", "AppManager", "AppUser")]
        public override ValueTask<Genre?> GetByIdAsync(int id)
        {
            CheckAccessing(MethodBase.GetCurrentMethod()!.GetAsyncOriginal());

            return ExecuteGetByIdAsync(id);
        }

        [Authorize("SysAdmin", "AppAdmin", "AppManager", "AppUser")]
        public override IQueryable<Genre> AsNoTrackingSet()
        {
            CheckAccessing(MethodBase.GetCurrentMethod()!);

            return ExecuteAsNoTrackingSet();
        }
    }
}
#endif