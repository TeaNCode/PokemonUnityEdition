using UnityEngine;
using System.Collections;


public struct Nature
{
    public static readonly Nature Hardy = new Nature(Statistic.None, Statistic.None);
    public static readonly Nature Lonely = new Nature(Statistic.Attack, Statistic.Defense);
    public static readonly Nature Brave = new Nature(Statistic.Attack, Statistic.Speed);
    public static readonly Nature Adamant = new Nature(Statistic.Attack, Statistic.SpecialAttack);
    public static readonly Nature Naughty = new Nature(Statistic.Attack, Statistic.SpecialDefense);
    public static readonly Nature Bold = new Nature(Statistic.Defense, Statistic.Attack);
    public static readonly Nature Docile = Hardy;
    public static readonly Nature Relaxed = new Nature(Statistic.Defense, Statistic.Speed);
    public static readonly Nature Impish = new Nature(Statistic.Defense, Statistic.SpecialAttack);
    public static readonly Nature Lax = new Nature(Statistic.Defense, Statistic.SpecialDefense);
    public static readonly Nature Timid = new Nature(Statistic.Speed, Statistic.Attack);
    public static readonly Nature Hasty = new Nature(Statistic.Speed, Statistic.Defense);
    public static readonly Nature Serious = Docile;
    public static readonly Nature Jolly = new Nature(Statistic.Speed, Statistic.SpecialAttack);
    public static readonly Nature Naive = new Nature(Statistic.Speed, Statistic.SpecialDefense);
    public static readonly Nature Modest = new Nature(Statistic.SpecialAttack, Statistic.Attack);
    public static readonly Nature Mild = new Nature(Statistic.SpecialAttack, Statistic.Defense);
    public static readonly Nature Quiet = new Nature(Statistic.SpecialAttack, Statistic.Speed);
    public static readonly Nature Bashful = Serious;
    public static readonly Nature Rash = new Nature(Statistic.SpecialAttack, Statistic.SpecialDefense);
    public static readonly Nature Calm = new Nature(Statistic.SpecialDefense, Statistic.Attack);
    public static readonly Nature Gentle = new Nature(Statistic.SpecialDefense, Statistic.Defense);
    public static readonly Nature Sassy = new Nature(Statistic.SpecialDefense, Statistic.Speed);
    public static readonly Nature Careful = new Nature(Statistic.SpecialDefense, Statistic.SpecialAttack);
    public static readonly Nature Quirky = Bashful;

    public Statistic buffedStat;
    public Statistic debuffedStat;

    private Nature(Statistic buffedStat, Statistic debuffedStat)
    {
        this.buffedStat = buffedStat;
        this.debuffedStat = debuffedStat;
    }
}
