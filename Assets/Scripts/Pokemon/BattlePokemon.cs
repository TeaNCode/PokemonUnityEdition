using UnityEngine;
using System.Collections;

public class BattlePokemon
{
    public Pokemon pokemon;
    public sbyte hpStages;
    public float hpMultiplier;
    public sbyte attackStages;
    public float attackMultiplier;
    public sbyte defenseStages;
    public float defenseMultiplier;
    public sbyte specialAttackStages;
    public float specialAttackMultiplier;
    public sbyte specialDefenseStages;
    public float specialDefenseMultiplier;
    public sbyte speedStages;
    public float speedMultiplier;
    public sbyte evasionStages;
    public float evasionMultiplier;
    public sbyte accuracyStages;
    public sbyte accuracyMultiplier;
    public ushort hp;
    public ushort attack;
    public ushort defense;
    public ushort specialAttack;
    public ushort specialDefense;
    public ushort speed;
    public float accuracy;
    public float evasion;

    public BattlePokemon(Pokemon pokemon)
    {
        this.pokemon = pokemon;
        this.hpMultiplier = 1;
        this.hpStages = 0;
        this.attackMultiplier = 1;
        this.attackStages = 0;
        this.defenseMultiplier = 1;
        this.defenseStages = 0;
        this.specialAttackMultiplier = 1;
        this.specialAttackStages = 0;
        this.specialDefenseMultiplier = 1;
        this.specialDefenseStages = 0;
        this.speedMultiplier = 1;
        this.speedStages = 0;

        updateStats();
    }

    public void updateStats()
    {
        sbyte numerator = 3;
        sbyte denominator = 3;
        if (hpStages > 0)
            numerator += hpStages;
        else
            denominator -= hpStages;
        hp = (ushort)Mathf.Floor(pokemon.hp * hpMultiplier * numerator / denominator);
        numerator = 3;
        denominator = 3;
        if (attackStages > 0)
            numerator += attackStages;
        else
            denominator -= attackStages;
        attack = (ushort)Mathf.Floor(pokemon.attack * attackMultiplier * numerator / denominator);
        numerator = 3;
        denominator = 3;
        if (defenseStages > 0)
            numerator += defenseStages;
        else
            denominator -= defenseStages;
        defense = (ushort)Mathf.Floor(pokemon.defense * defenseMultiplier * numerator / denominator);
        numerator = 3;
        denominator = 3;
        if (specialAttackStages > 0)
            numerator += specialAttackStages;
        else
            denominator -= specialAttackStages;
        specialAttack = (ushort)Mathf.Floor(pokemon.specialAttack * specialAttackMultiplier * numerator / denominator);
        numerator = 3;
        denominator = 3;
        if (specialDefenseStages > 0)
            numerator += specialDefenseStages;
        else
            denominator -= specialDefenseStages;
        specialDefense = (ushort)Mathf.Floor(pokemon.specialDefense * specialDefenseMultiplier * numerator / denominator);
        numerator = 3;
        denominator = 3;
        if (speedStages > 0)
            numerator += speedStages;
        else
            denominator -= speedStages;
        speed = (ushort)Mathf.Floor(pokemon.speed * speedMultiplier * numerator / denominator);
        numerator = 2;
        denominator = 2;
        if (accuracyStages > 0)
            numerator += accuracyStages;
        else
            denominator -= accuracyStages;
        accuracy = 1f * accuracyMultiplier * numerator / denominator;
        numerator = 2;
        denominator = 2;
        if (evasionStages > 0)
            numerator += evasionStages;
        else
            denominator -= evasionStages;
        evasion = 1f * evasionMultiplier * numerator / denominator;
    }
}
