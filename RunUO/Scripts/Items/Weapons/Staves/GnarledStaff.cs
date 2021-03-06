using System;
using Server.Network;
using Server.Items;
using Server.Spells;
using Server.Targeting;
using Server.Spells.Fourth;
using Server.Spells.Third;
using Server.Spells.Second;
using Server.Spells.First;
using Server.Spells.Fifth;

namespace Server.Items
{
	[FlipableAttribute( 0x13F8, 0x13F9 )]
	public class GnarledStaff : BaseStaff
	{
        public override WeaponAbility PrimaryAbility { get { return WeaponAbility.ConcussionBlow; } }
        public override WeaponAbility SecondaryAbility { get { return WeaponAbility.ParalyzingBlow; } }

        public override int AosStrengthReq { get { return 20; } }
        public override int AosMinDamage { get { return 15; } }
        public override int AosMaxDamage { get { return 17; } }
        public override int AosSpeed { get { return 33; } }

        public override int OldStrengthReq { get { return 20; } }
        public override int OldMinDamage { get { return 9; } }
        public override int OldMaxDamage { get { return 21; } }
        public override int OldSpeed { get { return 30; } }

        public override int InitMinHits { get { return 31; } }
        public override int InitMaxHits { get { return 50; } }

		[Constructable]
		public GnarledStaff() : base( 0x13F8 )
		{
			Weight = 3.0;
		}

		public GnarledStaff( Serial serial ) : base( serial )
		{
		}

        /*public override void OnSingleClick(Mobile from)
        {

            string durabilitylevel = GetDurabilityString();
            string accuracylevel = GetAccuracyString();
            string damagelevel = GetDamageString();
            string beginning;

            if ((durabilitylevel == "indestructible") || (accuracylevel == "accurate") || (accuracylevel == "eminently accurate") || (accuracylevel == "exceedingly accurate"))
            {
                beginning = "an ";
            }
            else
            {
                beginning = "a ";
            }

            if (this.Name != null)
            {
                from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", this.Name));
            }
            else
            {
                if (this.Quality == WeaponQuality.Exceptional)
                {
                    if (this.Crafter != null)
                        from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", String.Format("an exceptional gnarled staff (crafted by {0})", this.Crafter.Name)));
                    else
                        from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", "an exceptional gnarled staff"));
                }
                else if ((this.IsInIDList(from) == false) && ((this.DamageLevel != WeaponDamageLevel.Regular) || (Slayer == SlayerName.Silver) || (Effect != WeaponEffect.None) || (this.DurabilityLevel != WeaponDurabilityLevel.Regular) || (this.AccuracyLevel != WeaponAccuracyLevel.Regular)))
                {
                    from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", "a magic gnarled staff"));
                }
                else if (IsInIDList(from) || from.AccessLevel >= AccessLevel.GameMaster)
                {
                    if ((this.DamageLevel > WeaponDamageLevel.Regular || Effect != WeaponEffect.None) && ((this.DurabilityLevel == WeaponDurabilityLevel.Regular) && (this.AccuracyLevel == WeaponAccuracyLevel.Regular)))
                    {
                        from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", (Slayer == SlayerName.Silver ? "a silver " : "a ") + "gnarled staff " + damagelevel));
                    }
                    else if ((this.DurabilityLevel > WeaponDurabilityLevel.Regular) && ((this.DamageLevel == WeaponDamageLevel.Regular && Effect == WeaponEffect.None) && (this.AccuracyLevel == WeaponAccuracyLevel.Regular)))
                    {
                        from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", beginning + durabilitylevel + " gnarled staff"));
                    }
                    else if ((this.AccuracyLevel > WeaponAccuracyLevel.Regular) && ((this.DamageLevel == WeaponDamageLevel.Regular && Effect == WeaponEffect.None) && (this.DurabilityLevel == WeaponDurabilityLevel.Regular)))
                    {
                        from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", beginning + accuracylevel + " gnarled staff"));
                    }



                    else if (((this.DamageLevel > WeaponDamageLevel.Regular || Effect != WeaponEffect.None) && (this.DurabilityLevel > WeaponDurabilityLevel.Regular)) && (this.AccuracyLevel == WeaponAccuracyLevel.Regular))
                    {
                        from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", beginning + durabilitylevel + " gnarled staff " + damagelevel));
                    }
                    else if ((this.DamageLevel > WeaponDamageLevel.Regular || Effect != WeaponEffect.None) && (this.AccuracyLevel > WeaponAccuracyLevel.Regular) && (this.DurabilityLevel == WeaponDurabilityLevel.Regular))
                    {
                        from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", beginning + accuracylevel + " gnarled staff " + damagelevel));
                    }
                    else if ((this.DurabilityLevel > WeaponDurabilityLevel.Regular) && (this.AccuracyLevel > WeaponAccuracyLevel.Regular) && (this.DamageLevel == WeaponDamageLevel.Regular && Effect == WeaponEffect.None))
                    {
                        from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", beginning + durabilitylevel + ", " + accuracylevel + " gnarled staff"));
                    }
                    else if ((this.DurabilityLevel > WeaponDurabilityLevel.Regular) && (this.AccuracyLevel > WeaponAccuracyLevel.Regular) && (this.DamageLevel > WeaponDamageLevel.Regular || Effect != WeaponEffect.None))
                    {
                        from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", beginning + durabilitylevel + ", " + accuracylevel + " gnarled staff " + damagelevel));
                    }
                    else
                    {
                        from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", (Slayer == SlayerName.Silver ? "a silver " : "a ") + "gnarled staff"));
                    }
                }
                else
                {
                    from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", "a gnarled staff"));
                }
            }
        }*/

        public override void OnSingleClick(Mobile from)
        {
            if (this.Name != null)
            {
                from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", this.Name));
            }
            else
            {
                if (StaffEffect != WandEffect.None)
                {
                    if (IsInIDList(from))
                    {
                        if (StaffEffect == WandEffect.Clumsiness)
                            from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", String.Format("a gnarled staff of clumsiness ({0} charges)", Charges)));
                        else if (StaffEffect == WandEffect.Identification)
                            from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", String.Format("a gnarled staff of identification ({0} charges)", Charges)));
                        else if (StaffEffect == WandEffect.Paralyze)
                            from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", String.Format("a gnarled staff of ghoul's touch ({0} charges)", Charges)));
                        else if (StaffEffect == WandEffect.Feeblemindedness)
                            from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", String.Format("a gnarled staff of feeblemindedness ({0} charges)", Charges)));
                        else if (StaffEffect == WandEffect.Weakness)
                            from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", String.Format("a gnarled staff of weakness ({0} charges)", Charges)));
                        else if (StaffEffect == WandEffect.MagicArrow)
                            from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", String.Format("a gnarled staff of burning ({0} charges)", Charges)));
                        else if (StaffEffect == WandEffect.Harming)
                            from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", String.Format("a gnarled staff of wounding ({0} charges)", Charges)));
                        else if (StaffEffect == WandEffect.Fireball)
                            from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", String.Format("a gnarled staff of daemon's breath ({0} charges)", Charges)));
                        else if (StaffEffect == WandEffect.Curse)
                            from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", String.Format("a gnarled staff of evil ({0} charges)", Charges)));
                        else if (StaffEffect == WandEffect.Lightning)
                            from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", String.Format("a gnarled staff of thunder ({0} charges)", Charges)));
                        else if (StaffEffect == WandEffect.ManaDraining)
                            from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", String.Format("a gnarled staff of mage's bane ({0} charges)", Charges)));
                    }
                    else
                    {
                        from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", "a magic gnarled staff"));
                    }
                }
                else
                    from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", "a gnarled staff"));
            }
        }

        public override void OnDoubleClick(Mobile from)
        {
            if (StaffEffect != WandEffect.None)
            {
                if (!from.CanBeginAction(typeof(BaseWand)))
                    return;

                if (Parent == from)
                {
                    if (Charges > 0)
                        OnWandUse(from);
                    else
                        from.SendAsciiMessage("This item is out of charges."); // This item is out of charges.
                }
                else
                {
                    from.SendAsciiMessage("You must equip this item to use it."); // You must equip this item to use it.
                }
            }
            else
                base.OnDoubleClick(from);
        }

        public virtual void OnWandUse(Mobile from)
        {
            if (StaffEffect == WandEffect.Clumsiness)
                Cast(new ClumsySpell(from, this as GnarledStaff));
            else if (StaffEffect == WandEffect.Identification)
                base.OnWandUse(from);
            else if (StaffEffect == WandEffect.Paralyze)
                Cast(new ParalyzeSpell(from, this));
            else if (StaffEffect == WandEffect.Feeblemindedness)
                Cast(new FeeblemindSpell(from, this));
            else if (StaffEffect == WandEffect.Weakness)
                Cast(new WeakenSpell(from, this));
            else if (StaffEffect == WandEffect.MagicArrow)
                Cast(new MagicArrowSpell(from, this));
            else if (StaffEffect == WandEffect.Harming)
                Cast(new HarmSpell(from, this));
            else if (StaffEffect == WandEffect.Fireball)
                Cast(new FireballSpell(from, this));
            else if (StaffEffect == WandEffect.Curse)
                Cast(new CurseSpell(from, this));
            else if (StaffEffect == WandEffect.Lightning)
                Cast(new LightningSpell(from, this));
            else if (StaffEffect == WandEffect.ManaDraining)
                Cast(new ManaDrainSpell(from, this));
        }

        public override bool OnWandTarget(Mobile from, object o)
        {
            bool inlist = false;
            if (o is Item)
            {
                if (o is BaseWeapon)
                    inlist = ((BaseWeapon)o).IsInIDList(from);
                else if (o is BaseArmor)
                    inlist = ((BaseArmor)o).IsInIDList(from);
                else if (o is BaseClothing)
                    inlist = ((BaseClothing)o).IsInIDList(from);
                else if (o is BaseJewel)
                    inlist = ((BaseJewel)o).IsInIDList(from);

                if (o is BaseWeapon)
                    ((BaseWeapon)o).AddToIDList(from);
                else if (o is BaseArmor)
                    ((BaseArmor)o).AddToIDList(from);
                else if (o is BaseClothing)
                    ((BaseClothing)o).AddToIDList(from);
                else if (o is BaseJewel)
                    ((BaseJewel)o).AddToIDList(from);

                if (!Core.AOS)
                    ((Item)o).OnSingleClick(from);

                if (o is BaseWeapon && (((BaseWeapon)o).IDList.Count > 50 && !inlist || from.AccessLevel > AccessLevel.Player))
                    ((BaseWeapon)o).RemoveFromIDList(from);
                else if (o is BaseArmor && (((BaseArmor)o).IDList.Count > 50 && !inlist || from.AccessLevel > AccessLevel.Player))
                    ((BaseArmor)o).RemoveFromIDList(from);
                else if (o is BaseClothing && (((BaseClothing)o).IDList.Count > 50 && !inlist || from.AccessLevel > AccessLevel.Player))
                    ((BaseClothing)o).RemoveFromIDList(from);
                else if (o is BaseJewel && (((BaseJewel)o).IDList.Count > 50 && !inlist || from.AccessLevel > AccessLevel.Player))
                    ((BaseJewel)o).RemoveFromIDList(from);

                return (o is Item);
            }
            else if (o is Mobile)
            {
                ((Mobile)o).OnSingleClick(from);
                return (o is Mobile);
            }
            return true;
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}