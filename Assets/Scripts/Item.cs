using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Item : NetworkBehaviour
{

    public enum VegetableType
    {
        BEET,
        CARROT,
        RADISH
    }

    public VegetableType typeOfVeggie;
}
