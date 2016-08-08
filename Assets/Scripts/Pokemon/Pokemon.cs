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

    public static ushort calculateHP(byte species, byte level, byte hPIV, byte hPEV)
    {
        PokemonData speciesData = PokemonBaseDatabase.database[species];

        ushort hP = (ushort)(((2 * speciesData.baseHP + hPIV + (hPEV / 4f) * level) / 100f) + level + 10);

        return hP;
    }
}
