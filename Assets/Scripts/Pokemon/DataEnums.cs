using UnityEngine;
using System.Collections;

public enum Type : byte {Normal, Fighting, Flying, Poison, Ground,
    Rock, Bug, Ghost, Steel, Fire, Water, Grass, Electric, Psychic,
    Ice, Dragon, Dark};

public enum ExperienceGroup : byte {Erratic, Fast, MediumFast,
    MediumSlow, Slow, Fluctuating};

public enum EggGroup : byte {Monster, Water1, Bug, Flying, Field,
    Fairy, Grass, Undiscovered, Humanlike, Water3, Mineral,
    Amorphous, Water2, Ditto, Dragon };

public enum Nature : byte {Hardy, Lonely, Brave, Adamant, Naughty,
    Bold, Docile, Relaxed, Impish, Lax, Timid, Hasty, Serious,
    Jolly, Naive, Modest, Mild, Quiet, Bashful, Rash, Calm, Gentle,
    Sassy, Careful, Quirky};

public enum Gender: byte {Male, Female, Genderless};
