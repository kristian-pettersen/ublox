﻿using BinarySerialization;

namespace ublox
{
    public class Packet
    {
        public Packet()
        {
            SyncCharacters = Constants.SyncCharacters;
        }

        [FieldOrder(0)]
        public ushort SyncCharacters { get; set; }

        [FieldOrder(1)]
        [FieldFletcherChecksum("Checksum")]
        [SubtypeDefault(typeof(PacketContent))]
        public PacketContentBase Content { get; set; }

        [FieldOrder(2)]
        public ushort Checksum { get; set; }
    }
}
