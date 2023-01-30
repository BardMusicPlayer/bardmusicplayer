/*
 * Copyright(c) 2022 MoogleTroupe, GiR-Zippo
 * Licensed under the GPL v3 license. See https://github.com/BardMusicPlayer/BardMusicPlayer/blob/develop/LICENSE for full license information.
 */

using System.Drawing;
using BardMusicPlayer.Pigeonhole.JsonSettings.Autosave;
using BardMusicPlayer.Quotidian;

namespace BardMusicPlayer.Pigeonhole;

public class BmpPigeonhole : JsonSettings.JsonSettings
{
    private static BmpPigeonhole _instance;

    /// <summary>
    /// Initializes the pigeonhole file
    /// </summary>
    /// <param name="filename">full path to the json pigeonhole file</param>
    public static void Initialize(string filename)
    {
        if (Initialized) return;
        _instance = Load<BmpPigeonhole>(filename).EnableAutosave();
    }

    /// <summary>
    /// 
    /// </summary>
    public static bool Initialized => _instance != null;

    /// <summary>
    /// Gets this pigeonhole instance
    /// </summary>
    public static BmpPigeonhole Instance => _instance ?? throw new BmpException("This pigeonhole must be initialized first.");

    /// <summary>
    /// Sets PlayAllTracks
    /// </summary>
    public virtual bool PlayAllTracks { get; set; }

    /// <summary>
    /// Sets PlaylistDelay
    /// </summary>
    public virtual float PlaylistDelay { get; set; } = 1;

    /// <summary>
    /// Sets PlayAllTracks
    /// </summary>
    public virtual bool PlaylistAutoPlay { get; set; } = true;

    /// <summary>
    /// last loaded song
    /// </summary>
    public virtual string LastLoadedCatalog { get; set; } = "";

    /// <summary>
    /// last loaded song
    /// </summary>
    public virtual string SongDirectory { get; set; } = "songs/";

    /// <summary>
    /// hold long notes
    /// </summary>
    public virtual bool HoldNotes { get; set; } = true;

    /// <summary>
    /// Sets the autostart method
    /// </summary>
    public virtual int AutostartMethod { get; set; } = 1;

    /// <summary>
    /// last selected midi input device
    /// </summary>
    public virtual int MidiInputDev { get; set; } = -1;

    /// <summary>
    /// live midi play delay
    /// </summary>
    public virtual bool LiveMidiPlayDelay { get; set; }

    /// <summary>
    /// force the playback
    /// </summary>
    public virtual bool ForcePlayback { get; set; }

    /// <summary>
    /// unknown but used
    /// </summary>
    public virtual bool SigIgnore { get; set; } = false;

    /// <summary>
    /// LastCharId
    /// </summary>
    public virtual string LastCharId { get; set; } = "";

    /// <summary>
    /// BMP window location
    /// </summary>
    public virtual Point BmpLocation { get; set; } = Point.Empty;

    public virtual Size BmpSize { get; set; } = Size.Empty;

    /// <summary>
    /// Enable the 16 voice limit in Synthesizer
    /// </summary>
    public virtual bool EnableSynthVoiceLimiter { get; set; } = true;

    /// <summary>
    /// milliseconds till ready check confirmation.
    /// </summary>
    public virtual int EnsembleReadyDelay { get; set; } = 500;

    /// <summary>
    /// autoequip bards after song loaded
    /// </summary>
    public virtual bool AutoEquipBards { get; set; }

    /// <summary>
    /// keep the ensemble track settings
    /// </summary>
    public virtual bool EnsembleKeepTrackSetting { get; set; }

    /// <summary>
    /// ignores the progchange
    /// </summary>
    public virtual bool IgnoreProgChange { get; set; }

    /// <summary>
    /// milliseconds between game process scans / seer scanner startups.
    /// </summary>
    public virtual int SeerGameScanCooldown { get; set; } = 20;

    /// <summary>
    /// Contains the last path of an opened midi file
    /// </summary>
    public virtual string LastOpenedMidiPath { get; set; } = "";

    /// <summary>
    /// Contains the delay used for note pressing. This should be no less then 1 and no greater then 25.
    /// </summary>
    public virtual int NoteKeyDelay { get; set; } = 1;

    /// <summary>
    /// Contains the delay used for tone pressing. This should be no less then 1 and no greater then 25.
    /// </summary>
    public virtual int ToneKeyDelay { get; set; } = 3;

    /// <summary>
    ///     Use the Hypnotoad for instrument eq
    /// </summary>
    public virtual bool UsePluginForInstrumentOpen { get; set; }

    /// <summary>
    /// Defaults to log level Info
    /// </summary>
    public virtual BmpLog.Verbosity DefaultLogLevel { get; set; } = BmpLog.Verbosity.Info;
}