using UnityEngine;
using System.Collections;

public enum Type : byte {Normal, Fighting, Flying, Poison, Ground,
    Rock, Bug, Ghost, Steel, Fire, Water, Grass, Electric, Psychic,
    Ice, Dragon, Dark, Struggle};

public enum ExperienceGroup : byte {Erratic, Fast, MediumFast,
    MediumSlow, Slow, Fluctuating};

public enum EggGroup : byte {Monster, Water1, Bug, Flying, Field,
    Fairy, Grass, Undiscovered, Humanlike, Water3, Mineral,
    Amorphous, Water2, Ditto, Dragon };

public enum Gender: byte {Male, Female, Genderless};

public enum Statistic: byte {HP, Attack, Defense, SpecialAttack, SpecialDefense, Speed, None};

public enum MoveCategory: byte {Physical, Special, Status};
