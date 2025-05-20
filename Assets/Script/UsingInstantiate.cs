using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingInstantiate : MonoBehaviour
{

    public GameObject objectToSpawn;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           Instantiate (objectToSpawn, spawnPoint.position, spawnPoint.rotation);

           // Debug.Log(objectToSpawn +" "+ spawnPoint.position +" "+ spawnPoint.rotation);
        }
    }
}
