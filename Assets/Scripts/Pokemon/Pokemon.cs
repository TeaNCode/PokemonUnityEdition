using UnityEngine;
using System.Collections;

public class Pokemon
{
    public byte species;
    public string nickname;
    public Gender gender;
    public byte level;
    public ushort trainerID;
    public string oTName;
    public byte[] types;
    //public Move[] moves;
    public ushort hP;
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

    public static ushort calculateStatistic(Statistic statistic, byte species, byte level, byte IV, byte EV, Nature nature)
    {
        PokemonData speciesData = PokemonBaseDatabase.database[species];
        ushort stat;
        byte baseStat;

        if (statistic == Statistic.HP)
        {
             stat = (ushort)(((2 * speciesData.baseHP + IV + (EV / 4f) * level) / 100f) + level + 10);
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

        stat = ();

        return stat;
    }
}
