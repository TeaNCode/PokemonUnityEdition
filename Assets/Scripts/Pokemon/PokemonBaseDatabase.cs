using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class PokemonBaseDatabase
{
    public static List<PokemonData> database;

    public static void initializeDatabase()
    {
        database = new List<PokemonData>();
        database.Add(new PokemonData("Bulbasaur", "Seed Pokemon", 45, 49, 49, 65, 65, 45, Type.Grass, Type.Poison, 45, 64, 0, 0, 0, 1, 0, 0, 31, 5355, 70, ExperienceGroup.MediumSlow, EggGroup.Monster, EggGroup.Grass));
    }
}

public struct PokemonData
{
    public string speciesName;
    public string speciesType;
    public byte baseHP;
    public byte baseAttack;
    public byte baseDefense;
    public byte baseSpecialAttack;
    public byte baseSpecialDefense;
    public byte baseSpeed;
    public Type type1;
    public Type type2;
    public byte catchRate;
    public byte eXPYield;
    public byte hPEVYield;
    public byte attackEVYield;
    public byte defenseEVYield;
    public byte specialAttackEVYield;
    public byte specialDefenseEVYield;
    public byte speedEVYield;
    public byte genderRatio;
    public ushort eggSteps;
    public byte baseFriendship;
    public ExperienceGroup experienceGroup;
    public EggGroup eggGroup1;
    public EggGroup eggGroup2;
    //public Item item1;
    //public Item item2;
    //public Ability ability1;
    //public Ability ability2;

    public PokemonData(string speciesName, string speciesType, byte baseHP, byte baseAttack, byte baseDefense,
        byte baseSpecialAttack, byte baseSpecialDefense, byte baseSpeed, Type type1, Type type2, byte catchRate,
        byte eXPYield, byte hPEVYield, byte attackEVYield, byte defenseEVYield, byte specialAttackEVYield,
        byte specialDefenseEVYield, byte speedEVYield, byte genderRatio, ushort eggSteps, byte baseFriendship,
        ExperienceGroup experienceGroup, EggGroup eggGroup1, EggGroup eggGroup2)
    {
        this.speciesName = speciesName;
        this.speciesType = speciesType;
        this.baseHP = baseHP;
        this.baseAttack = baseAttack;
        this.baseDefense = baseDefense;
        this.baseSpecialAttack = baseSpecialAttack;
        this.baseSpecialDefense = baseSpecialDefense;
        this.baseSpeed = baseSpeed;
        this.type1 = type1;
        this.type2 = type2;
        this.catchRate = catchRate;
        this.eXPYield = eXPYield;
        this.hPEVYield = hPEVYield;
        this.attackEVYield = attackEVYield;
        this.defenseEVYield = defenseEVYield;
        this.specialAttackEVYield = specialAttackEVYield;
        this.specialDefenseEVYield = specialDefenseEVYield;
        this.speedEVYield = speedEVYield;
        this.genderRatio = genderRatio;
        this.eggSteps = eggSteps;
        this.baseFriendship = baseFriendship;
        this.experienceGroup = experienceGroup;
        this.eggGroup1 = eggGroup1;
        this.eggGroup2 = eggGroup2;
    }
}