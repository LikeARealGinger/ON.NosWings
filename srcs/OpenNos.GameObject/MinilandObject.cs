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

using OpenNos.Data;
using OpenNos.GameObject.Item.Instance;

namespace OpenNos.GameObject
{
    public class MapDesignObject : MinilandObjectDTO
    {
        #region Members

        public ItemInstance ItemInstance;

        #endregion

        #region Methods

        public string GenerateEffect(bool removed)
        {
            return $"eff_g  {ItemInstance.Item?.EffectValue ?? ItemInstance.Design} {MapX.ToString("00")}{MapY.ToString("00")} {MapX} {MapY} {(removed ? 1 : 0)}";
        }

        public string GenerateMapDesignObject(bool deleted)
        {
            return $"mlobj {(deleted ? 0 : 1)} {ItemInstance.Slot} {MapX} {MapY} {ItemInstance.Item.Width} {ItemInstance.Item.Height} 0 {ItemInstance.DurabilityPoint} 0 {(ItemInstance.Item.IsWarehouse ? 1 : 0)}";
        }

        #endregion
    }
}