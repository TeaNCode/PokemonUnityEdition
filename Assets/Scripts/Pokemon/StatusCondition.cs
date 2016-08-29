using UnityEngine;
using System.Collections;

public class StatusCondition
{
    public Status status;
    public byte turnsPassed;
    public Pokemon owner;

    public static readonly StatusCondition none = new StatusCondition();

    public StatusCondition(Status status)
    {
        this.status = status;
        turnsPassed = 0;
    }

    private StatusCondition(){}
}

public enum Status : byte {Burn, Freeze, Paralysis, Poison, BadPoison, Sleep,
    Confusion, Curse, Embargo, Encore, Flinch, HealBlock, Identification,
    Infatuation, Nightmare, PartialTrap, PerishSong, Seeding, Taunt,
    TelekeneticLevitation, Torment, Trapped, AquaRing, Bracing,
    CenterOfAttention, DefemseCurl, Glowing, Rooting, MagicCoat,
    MagneticLevitation, Minimize, Protection, Recharging, SemiInvulnerable,
    Substitute, TakingAim, TakingSunlight, Withdrawing, WhippingWhirlwind, CritBoost};
