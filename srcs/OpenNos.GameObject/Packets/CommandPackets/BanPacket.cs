﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)

using NosSharp.Enums;
using OpenNos.Core.Serializing;

namespace OpenNos.GameObject.Packets.CommandPackets
{
    [PacketHeader("$Ban", PassNonParseablePacket = true, Authority = AuthorityType.GameMaster)]
    public class BanPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public string CharacterName { get; set; }

        [PacketIndex(1)]
        public int Duration { get; set; }

        [PacketIndex(2, SerializeToEnd = true)]
        public string Reason { get; set; }

        public static string ReturnHelp()
        {
            return "$Ban CHARACTERNAME DURATION(DAYS) REASON";
        }

        public override string ToString()
        {
            return $"Ban Command CharacterName: {CharacterName} Duration: {Duration} Reason: {Reason}";
        }

        #endregion
    }
}