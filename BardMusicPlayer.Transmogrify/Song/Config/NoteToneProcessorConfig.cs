﻿/*
 * Copyright(c) 2021 MoogleTroupe
 * Licensed under the GPL v3 license. See https://github.com/BardMusicPlayer/BardMusicPlayer/blob/develop/LICENSE for full license information.
 */

using System.Collections.Generic;
using BardMusicPlayer.Quotidian.Structs;
using BardMusicPlayer.Transmogrify.Song.Config.Interfaces;

namespace BardMusicPlayer.Transmogrify.Song.Config
{
    public class NoteToneProcessorConfig : IProcessorConfig
    {
        ///<inheritdoc/>
        public int Track { get; set; } = 0;

        ///<inheritdoc/>
        public List<long> IncludedTracks { get; set; } = new();

        ///<inheritdoc/>
        public int PlayerCount { get; set; } = 1;

        /// <summary>
        /// The instrument tone for this track
        /// </summary>
        public InstrumentTone InstrumentTone { get; set; } = InstrumentTone.Strummed;

        /// <summary>
        /// The mapper of notes to tone and note
        /// </summary>
        public Dictionary<int, (int, int)> Mapper { get; set; } = new(109)
        {
            { 12, (-1, -1) },
            { 13, (-1, -1) },
            { 14, (-1, -1) },
            { 15, (-1, -1) },
            { 16, (-1, -1) },
            { 17, (-1, -1) },
            { 18, (-1, -1) },
            { 19, (-1, -1) },
            { 20, (-1, -1) },
            { 21, (-1, -1) },
            { 22, (-1, -1) },
            { 23, (-1, -1) },
            { 24, (-1, -1) },
            { 25, (-1, -1) },
            { 26, (-1, -1) },
            { 27, (-1, -1) },
            { 28, (-1, -1) },
            { 29, (-1, -1) },
            { 30, (-1, -1) },
            { 31, (-1, -1) },
            { 32, (-1, -1) },
            { 33, (-1, -1) },
            { 34, (-1, -1) },
            { 35, (-1, -1) },
            { 36, (-1, -1) },
            { 37, (-1, -1) },
            { 38, (-1, -1) },
            { 39, (-1, -1) },
            { 40, (-1, -1) },
            { 41, (-1, -1) },
            { 42, (-1, -1) },
            { 43, (-1, -1) },
            { 44, (-1, -1) },
            { 45, (-1, -1) },
            { 46, (-1, -1) },
            { 47, (-1, -1) },
            { 48, (-1, -1) },
            { 49, (-1, -1) },
            { 50, (-1, -1) },
            { 51, (-1, -1) },
            { 52, (-1, -1) },
            { 53, (-1, -1) },
            { 54, (-1, -1) },
            { 55, (-1, -1) },
            { 56, (-1, -1) },
            { 57, (-1, -1) },
            { 58, (-1, -1) },
            { 59, (-1, -1) },
            { 60, (-1, -1) },
            { 61, (-1, -1) },
            { 62, (-1, -1) },
            { 63, (-1, -1) },
            { 64, (-1, -1) },
            { 64, (-1, -1) },
            { 65, (-1, -1) },
            { 66, (-1, -1) },
            { 67, (-1, -1) },
            { 68, (-1, -1) },
            { 69, (-1, -1) },
            { 70, (-1, -1) },
            { 71, (-1, -1) },
            { 72, (-1, -1) },
            { 73, (-1, -1) },
            { 74, (-1, -1) },
            { 74, (-1, -1) },
            { 75, (-1, -1) },
            { 76, (-1, -1) },
            { 77, (-1, -1) },
            { 78, (-1, -1) },
            { 79, (-1, -1) },
            { 80, (-1, -1) },
            { 81, (-1, -1) },
            { 82, (-1, -1) },
            { 83, (-1, -1) },
            { 84, (-1, -1) },
            { 85, (-1, -1) },
            { 86, (-1, -1) },
            { 87, (-1, -1) },
            { 88, (-1, -1) },
            { 89, (-1, -1) },
            { 90, (-1, -1) },
            { 91, (-1, -1) },
            { 92, (-1, -1) },
            { 93, (-1, -1) },
            { 94, (-1, -1) },
            { 95, (-1, -1) },
            { 96, (-1, -1) },
            { 97, (-1, -1) },
            { 98, (-1, -1) },
            { 99, (-1, -1) },
            { 100, (-1, -1) },
            { 101, (-1, -1) },
            { 102, (-1, -1) },
            { 103, (-1, -1) },
            { 104, (-1, -1) },
            { 105, (-1, -1) },
            { 106, (-1, -1) },
            { 107, (-1, -1) },
            { 108, (-1, -1) },
            { 109, (-1, -1) },
            { 110, (-1, -1) },
            { 111, (-1, -1) },
            { 112, (-1, -1) },
            { 113, (-1, -1) },
            { 114, (-1, -1) },
            { 115, (-1, -1) },
            { 116, (-1, -1) },
            { 117, (-1, -1) },
            { 118, (-1, -1) },
            { 119, (-1, -1) },
            { 120, (-1, -1) }
        };
    }
}