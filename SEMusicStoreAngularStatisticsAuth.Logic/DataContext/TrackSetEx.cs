#if GENERATEDCODE_ON
using SEMusicStoreAngularStatisticsAuth.Logic.Entities;
using System.Reflection;

namespace SEMusicStoreAngularStatisticsAuth.Logic.DataContext
{
    partial class TrackSet
    {
        protected override void CheckAccessing(MethodBase methodBase)
        {
            if (methodBase.Name.Equals(nameof(AsQuerySet)) == false
                && methodBase.Name.Equals(nameof(AsNoTrackingSet)) == false)
            {
                base.CheckAccessing(methodBase);
            }
        }
        internal override IQueryable<Track> ExecuteAsQuerySet()
        {
            return base.ExecuteAsQuerySet().Include(e => e.Album)
                                           .Include(e => e.Genre);
        }
    }
}
#endif
