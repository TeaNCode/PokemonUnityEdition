using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Natures
{
    public static Dictionary<Nature, Statistic> buffedStat = new Dictionary<Nature, Statistic>();
    public static Dictionary<Nature, Statistic> debuffedStat = new Dictionary<Nature, Statistic>();

    public static void fillDictionaries()
    {
        buffedStat.Add(Nature.Hardy, Statistic.None);
        debuffedStat.Add(Nature.Hardy, Statistic.None);
        buffedStat.Add(Nature.Lonely, Statistic.Attack);
        debuffedStat.Add(Nature.Lonely, Statistic.Defense);
    }
}

public enum Nature : byte
{
    Hardy, Lonely, Brave, Adamant, Naughty,
    Bold, Docile, Relaxed, Impish, Lax, Timid, Hasty, Serious,
    Jolly, Naive, Modest, Mild, Quiet, Bashful, Rash, Calm, Gentle,
    Sassy, Careful, Quirky
};
