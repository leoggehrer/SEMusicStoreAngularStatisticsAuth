﻿using SEMusicStoreAngularStatisticsAuth.Common.Modules.Attributes;

namespace SEMusicStoreAngularStatisticsAuth.Logic.Entities.Views
{
    /// <summary>
    /// Represents statistical information about an artist, including the number of songs,
    /// total duration, and average song duration.
    /// </summary>
    [View("ArtistStatistics")]
    public partial class ArtistStatistic : ViewObject
    {
        /// <summary>
        /// Gets or sets the unique identifier of the artist.
        /// </summary>
        public IdType ArtistId { get; set; }

        /// <summary>
        /// Gets or sets the name of the artist.
        /// </summary>
        public string ArtistName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the number of songs by the artist.
        /// </summary>
        public int NumberSongs { get; set; }
        /// <summary>
        /// Gets or sets the total duration of all songs by the artist, in seconds.
        /// </summary>
        public System.Int64 TotalSongTimeSeconds { get; set; }
        /// <summary>
        /// Gets or sets the average duration of the artist's songs, in seconds.
        /// </summary>
        public System.Int64 AverageSongTimeSeconds { get; set; }
    }
}
