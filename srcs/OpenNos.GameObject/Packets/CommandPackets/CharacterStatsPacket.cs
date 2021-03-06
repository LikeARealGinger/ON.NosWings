﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)

using NosSharp.Enums;
using OpenNos.Core.Serializing;

namespace OpenNos.GameObject.Packets.CommandPackets
{
    [PacketHeader("$CharStat", PassNonParseablePacket = true, Authority = AuthorityType.GameMaster)]
    public class CharacterStatsPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public string CharacterName { get; set; }

        public static string ReturnHelp()
        {
            return "$CharStat CHARACTERNAME";
        }

        #endregion
    }
}