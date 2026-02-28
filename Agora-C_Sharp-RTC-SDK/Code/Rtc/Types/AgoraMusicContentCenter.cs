using System;

namespace Agora.Rtc
{

    ///
    /// <summary>
    /// Detailed information about the music resource list.
    /// </summary>
    ///
    public class MusicCollection
    {
        ///
        /// <summary>
        /// The number of music items in the music resource list for this request.
        /// </summary>
        ///
        public int count;
        ///
        /// <summary>
        /// The total number of music resources in the list.
        /// </summary>
        ///
        public int total;
        ///
        /// <summary>
        /// The current page number, starting from 1 by default.
        /// </summary>
        ///
        public int page;
        ///
        /// <summary>
        /// The total number of pages in the current music resource list, with a maximum value of 50.
        /// </summary>
        ///
        public int pageSize;
        ///
        /// @ignore
        ///
        public Music[] music;
    };
}