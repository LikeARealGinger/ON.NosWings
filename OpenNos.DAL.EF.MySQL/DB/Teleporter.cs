//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenNos.DAL.EF.MySQL.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Teleporter
    {
        public short TeleporterId { get; set; }
        public short Index { get; set; }
        public short MapX { get; set; }
        public short MapY { get; set; }
        public short MapId { get; set; }
        public int MapNpcId { get; set; }
    
        public virtual Map map { get; set; }
        public virtual MapNpc mapnpc { get; set; }
    }
}
