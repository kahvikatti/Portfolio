using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//This script is attached to the player as well as all the stops in the game.
public class Item : MonoBehaviour
{
    public enum ItemType
    {
        Kuvernööri,
        Ooretti,
        JP,
        KebabJuha,
        Päppis,
        Reksi,
        Jake,
        Hanski,
        Jacques,
        None
    }

    //Item that player currently has
    public ItemType itemType;

    //Item that needs to be brought to the stop
    public ItemType itemTypeCheck;

    //Item that needs to be brought to the last stop
    public ItemType lastItemCheck;
}
