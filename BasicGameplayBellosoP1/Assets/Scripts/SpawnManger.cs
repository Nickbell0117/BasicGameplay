using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    private float startDelay2 = 4;
    private float startDelay3 = 5;
    private float spawnInterval2 = 3.0f;
    private float spawnInterval3 = 1.0f;

    public float sideSpawnMinZ; 
    public float sideSpawnMaxZ; 
    public float sideSpawnX;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnLeftAnimal", startDelay2, spawnInterval2);
        InvokeRepeating("SpawnRightAnimal", startDelay3, spawnInterval3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnLeftAnimal()
    {
    int animalIndex = Random.Range(0, animalPrefabs.Length); 
    Vector3 spawnPos =new Vector3(-sideSpawnX, 0,Random.Range(sideSpawnMinZ, sideSpawnMaxZ)); 
    Vector3 rotation = new Vector3(0, 90, 0);
    Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }

    void SpawnRightAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length); 
        Vector3 spawnPos =new Vector3(sideSpawnX, 0,Random.Range(sideSpawnMinZ, sideSpawnMaxZ)); 
        Vector3 rotation = new Vector3(0, -90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }
}
