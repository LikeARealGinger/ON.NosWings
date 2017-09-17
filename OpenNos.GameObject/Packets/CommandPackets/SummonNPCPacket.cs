﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)

using OpenNos.Core;
using OpenNos.Domain;

namespace OpenNos.GameObject.CommandPackets
{
    [PacketHeader("$SummonNPC", PassNonParseablePacket = true, Authority = AuthorityType.GameMaster)]
    public class SummonNpcPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public short NpcMonsterVNum { get; set; }

        [PacketIndex(1)]
        public byte Amount { get; set; }

        [PacketIndex(2)]
        public bool IsMoving { get; set; }

        public static string ReturnHelp()
        {
            return "$SummonNPC MONSTERVNUM AMOUNT MOVE";
        }

        #endregion
    }
}