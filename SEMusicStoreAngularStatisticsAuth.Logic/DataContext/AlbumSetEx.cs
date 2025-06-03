#if GENERATEDCODE_ON
using SEMusicStoreAngularStatisticsAuth.Logic.Entities;
using SEMusicStoreAngularStatisticsAuth.Logic.Modules.Security;
using System.Reflection;

namespace SEMusicStoreAngularStatisticsAuth.Logic.DataContext
{
    [Authorize("SysAdmin", "AppAdmin", "AppManger")]
    partial class AlbumSet
    {
        //[AllowAnonymous]
        //public override IQueryable<Album> AsNoTrackingSet()
        //{
        //    CheckReadAccessing(MethodBase.GetCurrentMethod()!);

        //    return ExecuteAsNoTrackingSet();
        //}

        protected override void CheckReadAccessing(MethodBase methodBase)
        {
            System.Diagnostics.Debug.WriteLine("AlbumSet: Read access is permitted.");
        }

        protected override void CheckUpdateAccessing(MethodBase methodBase)
        {
            base.CheckUpdateAccessing(methodBase);
        }
        internal override IQueryable<Album> ExecuteAsQuerySet()
        {
            return base.ExecuteAsQuerySet().Include(e => e.Artist);
        }
    }

}
#endif
