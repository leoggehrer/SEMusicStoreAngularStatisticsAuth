using SEMusicStoreAngularStatisticsAuth.Common.Modules.Attributes;

namespace SEMusicStoreAngularStatisticsAuth.Logic.Entities.Views
{
    [View("GenreTracks")]
    public partial class GenreTrack : ViewObject
    {
        /// <summary>
        /// Gets or sets the unique identifier of the track.
        /// </summary>
        public IdType GenreId { get; set; }

        /// <summary>
        /// Gets or sets the name of the genre.
        /// </summary>
        public string GenreName { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the number of songs by the genre.
        /// </summary>
        public int NumberSongs { get; set; }
    }
}
