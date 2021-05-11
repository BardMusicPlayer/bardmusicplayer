﻿/*
 * Copyright(c) 2021 MoogleTroupe, 2018-2020 parulina
 * Licensed under the GPL v3 license. See https://github.com/BardMusicPlayer/BardMusicPlayer/blob/develop/LICENSE for full license information.
 */

using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace BardMusicPlayer.Updater
{
    internal static class Extensions
    {
        internal static T DeserializeFromJson<T>(this string json)
        {
            var deserializer = new DataContractJsonSerializer(typeof(T));
            using var stream = new MemoryStream(Encoding.Unicode.GetBytes(json));
            return (T)deserializer.ReadObject(stream);
        }

        internal static string SerializeToJson<T>(this T type)
        {
            var serializer = new DataContractJsonSerializer(typeof(T));
            using var stream = new MemoryStream();
            serializer.WriteObject(stream, type);
            stream.Seek(0, SeekOrigin.Begin);
            using var reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }
    }
}
