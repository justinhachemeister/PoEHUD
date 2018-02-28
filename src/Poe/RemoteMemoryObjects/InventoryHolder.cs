﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class InventoryHolder : RemoteMemoryObject
    {
        public const int StructSize = 0x20;
        public int Id => M.ReadInt(Address);
        public Inventory2 Inventory => ReadObject<Inventory2>(Address + 0x8);

        public override string ToString()
        {
            return $"InventoryType: {Inventory.InventType}, InventorySlot: {Inventory.InventSlot}, IsRequested: {Inventory.IsRequested}, ItemsCount: {Inventory.Items.Count}";
        }
    }
}
