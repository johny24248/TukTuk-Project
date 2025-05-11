using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject traffic;
    public float SpawnRangeX = 0.8f;
    public float SpawnRangeZ = 25f;
    public float SpawnRangeY = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 3, 9);
        InvokeRepeating("SpawnTraffic", 10, 16);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstacle()
    {
        Vector3 spawnposz = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), SpawnRangeY, SpawnRangeZ);
        Instantiate(obstacle, spawnposz, obstacle.transform.rotation);
    }
    void SpawnTraffic()
    {
        Vector3 spawnposz = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), SpawnRangeY, SpawnRangeZ);
        Instantiate(traffic, spawnposz, traffic.transform.rotation);
    }
}
