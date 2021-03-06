﻿using System;
using System.ComponentModel.DataAnnotations;
using OpenNos.Data.Base;

namespace OpenNos.Data
{
    public class LogChatDTO : MappingBaseDTO
    {
        [Key]
        public long LogId { get; set; }

        public long? CharacterId { get; set; }

        public byte ChatType { get; set; }

        [MaxLength(255)]
        public string ChatMessage { get; set; }

        [MaxLength(255)]
        public string IpAddress { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
