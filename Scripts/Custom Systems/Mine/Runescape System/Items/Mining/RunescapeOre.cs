﻿

namespace Server.Runescape
{
    public abstract class RunescapeOre : Item
    {
        private Ores mOreType;

        public Ores OreType
        {
            get { return mOreType; }
        }

        public override int Hue
        {
            get { return Utilities.Hue(OreType); }
            set { base.Hue = value; }
        }


        public RunescapeOre(Ores oreType)
            : base(Utility.RandomBool() ? 0x19B9 : Utility.Random(4) + 0x19B7)
        {
            mOreType = oreType;
            Stackable = true;
        }

        public RunescapeOre(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0);

            writer.Write((int)mOreType);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            switch (version)
            {
                case 0:
                    {
                        mOreType = (Ores)reader.ReadInt();
                        break;
                    }
            }
        }
    }

    public class ClayOre : RunescapeOre
    {
        [Constructable]
        public ClayOre() : base(Ores.Clay) { }

        public ClayOre(Serial serial) : base(serial) { }

        public override string DefaultName { get { return "Clay Ore"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }

    public class RuneOre : RunescapeOre
    {
        [Constructable]
        public RuneOre() : base(Ores.Rune) { }

        public RuneOre(Serial serial) : base(serial) { }

        public override string DefaultName { get { return "Rune Ore"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }

    public class RuneEssence : RunescapeOre
    {
        [Constructable]
        public RuneEssence() : base(Ores.RuneEssence) { }

        public RuneEssence(Serial serial) : base(serial) { }

        public override string DefaultName { get { return "Rune Essence"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }

    public class AdamantiteOre : RunescapeOre
    {
        [Constructable]
        public AdamantiteOre() : base(Ores.Adamantite) { }

        public AdamantiteOre(Serial serial) : base(serial) { }

        public override string DefaultName { get { return "Adamantite Ore"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }

    public class MithrilOre : RunescapeOre
    {
        [Constructable]
        public MithrilOre() : base(Ores.Mithril) { }

        public MithrilOre(Serial serial) : base(serial) { }

        public override string DefaultName { get { return "Mithril Ore"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }

    public class CoalOre : RunescapeOre
    {
        [Constructable]
        public CoalOre() : base(Ores.Coal) { }

        public CoalOre(Serial serial) : base(serial) { }

        public override string DefaultName { get { return "Coal Ore"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }

    public class GoldMetalOre : RunescapeOre
    {
        [Constructable]
        public GoldMetalOre() : base(Ores.Gold) { }

        public GoldMetalOre(Serial serial) : base(serial) { }

        public override string DefaultName { get { return "Gold Ore"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }

    public class SilverMetalOre : RunescapeOre
    {
        [Constructable]
        public SilverMetalOre() : base(Ores.Silver) { }

        public SilverMetalOre(Serial serial) : base(serial) { }

        public override string DefaultName { get { return "Silver Ore"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }

    public class IronMetalOre : RunescapeOre
    {
        [Constructable]
        public IronMetalOre() : base(Ores.Iron) { }

        public IronMetalOre(Serial serial) : base(serial) { }

        public override string DefaultName { get { return "Iron Ore"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }

    public class TinOre : RunescapeOre
    {
        [Constructable]
        public TinOre() : base(Ores.Tin) { }

        public TinOre(Serial serial) : base(serial) { }

        public override string DefaultName { get { return "Tin Ore"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }

    public class CopperMetalOre : RunescapeOre
    {
        [Constructable]
        public CopperMetalOre() : base(Ores.Copper) { }

        public CopperMetalOre(Serial serial) : base(serial) { }

        public override string DefaultName { get { return "Copper Ore"; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}
