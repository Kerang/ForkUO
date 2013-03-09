﻿using System;

namespace Server.Items
{
    [FlipableAttribute(0x1081, 0x1082)]
    public class CustomLeather : BaseLeather, ICustomItem
    {
        [Constructable]
        public CustomLeather(String resource) : this(resource, 1)
        {
        }

        [Constructable]
        public CustomLeather(String resource, int amount) : base(resource, amount)
        {
        }

        public CustomLeather(Serial serial) : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}
