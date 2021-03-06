﻿/*
 * This file is part of the OpenNos Emulator Project. See AUTHORS file for Copyright information
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 */

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenNos.DAL.EF.Entities
{
    public class MapType
    {
        #region Instantiation

        public MapType()
        {
            MapTypeMap = new HashSet<MapTypeMap>();
            Drops = new HashSet<Drop>();
        }

        #endregion

        #region Properties

        public virtual ICollection<Drop> Drops { get; set; }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short MapTypeId { get; set; }

        public virtual ICollection<MapTypeMap> MapTypeMap { get; set; }

        public string MapTypeName { get; set; }

        public short PotionDelay { get; set; }

        public virtual RespawnMapType RespawnMapType { get; set; }

        public long? RespawnMapTypeId { get; set; }

        public virtual RespawnMapType ReturnMapType { get; set; }

        public long? ReturnMapTypeId { get; set; }

        #endregion
    }
}