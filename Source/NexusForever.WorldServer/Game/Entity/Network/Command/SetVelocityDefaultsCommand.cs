﻿using NexusForever.Shared.Network;

namespace NexusForever.WorldServer.Game.Entity.Network.Command
{
    [EntityCommand(EntityCommand.SetVelocityDefaults)]
    public class SetVelocityDefaultsCommand : IEntityCommandModel
    {
        public bool Blend { get; set; }

        public void Read(GamePacketReader reader)
        {
            Blend = reader.ReadBit();
        }

        public void Write(GamePacketWriter writer)
        {
            writer.Write(Blend);
        }
    }
}
