using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject player;
    public GameObject[] triangleprefabs;
    private Vector3 spawmObstaclePosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToHorizon = Vector3.Distance(player.gameObject.transform.position, spawmObstaclePosition);
        if(distanceToHorizon < 120)
        {
            SpawnTriangles();
        }
    }

    void SpawnTriangles()
    {
        spawmObstaclePosition = new Vector3(0, 0, spawmObstaclePosition.z + 30);
        Instantiate(triangleprefabs[(UnityEngine.Random.Range(0,triangleprefabs.Length))], spawmObstaclePosition, Quaternion.identity);
    }
}
