using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject hazard;
    public Vector3 spawnValues;
    public int numberOfAsteroids;
    void Start()
    {
   
        SpawnWaves();
    }

    void SpawnWaves()
    {
        for(int i=0; i<numberOfAsteroids ;++i)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
            Quaternion spawnRotation = Quaternion.identity;
            hazard = GetComponentInChildren<GameObject>();
            Instantiate(hazard, spawnPosition, spawnRotation);
        }

    }

}
