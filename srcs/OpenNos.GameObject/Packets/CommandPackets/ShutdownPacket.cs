﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)

using NosSharp.Enums;
using OpenNos.Core.Serializing;

namespace OpenNos.GameObject.Packets.CommandPackets
{
    [PacketHeader("$Shutdown", PassNonParseablePacket = true, Authority = AuthorityType.GameMaster)]
    public class ShutdownPacket : PacketDefinition
    {
        public static string ReturnHelp()
        {
            return "$Shutdown";
        }
    }
}