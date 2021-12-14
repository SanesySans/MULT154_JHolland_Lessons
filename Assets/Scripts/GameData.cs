using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public static float gamePlayStart { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void OnDestroy()
    {

        Debug.Log("Player started at " + gamePlayStart + " seconds.");
    }
}
