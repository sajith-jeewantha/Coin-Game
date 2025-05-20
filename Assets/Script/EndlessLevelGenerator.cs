using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessLevelGenerator : MonoBehaviour
{
    public GameObject[] titlePerfabs;
    public Transform player;
    public float tileLength;
    public int TilesOnScreen = 5;
    public float SpawnZ = 0f; //Position to spawn the next tile
    private void Start()
    {
       for(int i = 0; i< TilesOnScreen; i++)
        {

        }
    }
}
