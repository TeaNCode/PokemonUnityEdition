using UnityEngine;
using System.Collections;

public abstract class PokemonUnityEdition
{
    public static void startGame(bool load)
    {
        initialization();
    }

    public static void initialization()
    {
        PokemonBaseDatabase.initializeDatabase();
    }
}
