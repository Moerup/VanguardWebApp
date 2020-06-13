using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VanguardWebApp.Enums
{
    public enum Slot
    {
        Head,
        Neck,
        Shoulder,
        Back,
        Chest,
        Wrist,
        Hands,
        Waist,
        Legs,
        Feet,
        Finger,
        Trinket,

        [EnumMember(Value = "Main Hand")]
        MainHand,

        [EnumMember(Value = "One-hand")]
        OneHand,

        [EnumMember(Value = "Off Hand")]
        OffHand,

        [EnumMember(Value = "Held in Off-Hand")]
        HeldInOffHand,

        [EnumMember(Value = "Two-hand")]
        TwoHand,

        Ranged
    }

    public static class Groups
    {
        public static bool IsArmor(Slot slot)
        {
            switch (slot)
            {
                case Slot.Head:
                case Slot.Neck:
                case Slot.Shoulder:
                case Slot.Back:
                case Slot.Chest:
                case Slot.Wrist:
                case Slot.Hands:
                case Slot.Waist:
                case Slot.Legs:
                case Slot.Feet:
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsWeapon(Slot slot)
        {
            switch (slot)
            {
                case Slot.MainHand:
                case Slot.OneHand:
                case Slot.OffHand:
                case Slot.HeldInOffHand:
                case Slot.TwoHand:
                    return true;
                default:
                    return false;
            }
        }
    }
}
