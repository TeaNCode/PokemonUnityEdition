using UnityEngine;
using System.Collections;
using System;

public class Pokemon
{
    public byte species;
    public string nickname;
    public Gender gender;
    public byte level;
    public ushort trainerID;
    public ushort secretID;
    public string oTName;
    public byte[] types;
    //public Move[] moves;
    public ushort hP;
    public ushort hpRemaining;
    public ushort attack;
    public ushort defense;
    public ushort specialAttack;
    public ushort specialDefense;
    public ushort speed;
    public byte hPIV;
    public byte attackIV;
    public byte defenseIV;
    public byte specialAttackIV;
    public byte specialDefenseIV;
    public byte speedIV;
    public byte hPEV;
    public byte attackEV;
    public byte defenseEV;
    public byte specialAttackEV;
    public byte specialDefenseEV;
    public byte speedEV;
    //public Item heldItem;
    public StatusCondition statusCondition;
    //public Ability ability;
    public bool Shiny;

    public Pokemon(byte species, Gender gender, byte level, byte hPIV, byte attackIV, byte defenseIV, byte specialAttackIV, byte specialDefenseIV, byte speedIV)
    {
        this.species = species;
        this.gender = gender;
        this.level = level;
        this.hPIV = hPIV;
        this.attackIV = attackIV;
        this.defenseIV = defenseIV;
        this.specialAttackIV = specialAttackIV;
        this.specialDefenseIV = specialDefenseIV;
    }

    public static Pokemon generatePokemon(byte species, byte level)
    {
        System.Random random = new System.Random();
        Byte[] bytes = new Byte[4];
        random.NextBytes(bytes);
        uint personality = BitConverter.ToUInt32(bytes, 0);

        Pokemon pokemon;
        Gender gender;
        Nature nature;

        if (PokemonBaseDatabase.database[species - 1].genderRatio == 255)
            gender = Gender.Genderless;
        else if (bytes[4] >= PokemonBaseDatabase.database[species - 1].genderRatio)
            gender = Gender.Male;
        else
            gender = Gender.Female;
        byte natureNum = (byte)(personality % 25);

        if (natureNum == 0) nature = Nature.Hardy;
        else if (natureNum == 1) nature = Nature.Lonely;
        else if (natureNum == 2) nature = Nature.Brave;
        else if (natureNum == 3) nature = Nature.Adamant;
        else if (natureNum == 4) nature = Nature.Naughty;
        else if (natureNum == 5) nature = Nature.Bold;
        else if (natureNum == 6) nature = Nature.Docile;
        else if (natureNum == 7) nature = Nature.Relaxed;
        else if (natureNum == 8) nature = Nature.Impish;
        else if (natureNum == 9) nature = Nature.Lax;
        else if (natureNum == 10) nature = Nature.Timid;
        else if (natureNum == 11) nature = Nature.Hasty;
        else if (natureNum == 12) nature = Nature.Serious;
        else if (natureNum == 13) nature = Nature.Jolly;
        else if (natureNum == 14) nature = Nature.Naive;
        else if (natureNum == 15) nature = Nature.Modest;
        else if (natureNum == 16) nature = Nature.Mild;
        else if (natureNum == 17) nature = Nature.Quiet;
        else if (natureNum == 18) nature = Nature.Bashful;
        else if (natureNum == 19) nature = Nature.Rash;
        else if (natureNum == 20) nature = Nature.Calm;
        else if (natureNum == 21) nature = Nature.Gentle;
        else if (natureNum == 22) nature = Nature.Sassy;
        else if (natureNum == 23) nature = Nature.Careful;
        else nature = Nature.Quirky;

        ushort firstHalf = (ushort)Math.Floor(personality / 65536.0);
        ushort secondHalf = (ushort)(personality % 65536);

        if(firstHalf == PlayerScript.trainerID)
    }

    public static ushort calculateStatistic(Statistic statistic, byte species, byte level, byte IV, byte EV, Nature nature)
    {
        PokemonData speciesData = PokemonBaseDatabase.database[species - 1];
        ushort stat;
        byte baseStat;
        float natureMultiplier = 1f;

        if (statistic == Statistic.HP)
        {
             stat = (ushort)Math.Floor((((2f * speciesData.baseHP + IV + (EV / 4f)) * level) / 100f) + level + 10);
            return stat;
        }
        else if(statistic == Statistic.Attack)
        {
            baseStat = speciesData.baseAttack;
        }
        else if(statistic == Statistic.Defense)
        {
            baseStat = speciesData.baseDefense;
        }
        else if(statistic == Statistic.SpecialAttack)
        {
            baseStat = speciesData.baseSpecialAttack;
        }
        else if(statistic == Statistic.SpecialDefense)
        {
            baseStat = speciesData.baseSpecialDefense;
        }
        else
        {
            baseStat = speciesData.baseSpeed;
        }

        if (nature.buffedStat == statistic)
            natureMultiplier = 1.1f;
        else if (nature.debuffedStat == statistic)
            natureMultiplier = .9f;

        stat = (ushort)Math.Floor(((((2f * baseStat + IV + (EV / 4f)) * level) / 100f) + 5) * natureMultiplier);

        return stat;
    }
}
