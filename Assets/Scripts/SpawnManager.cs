using System.Collections;
using System.Collections.Generic; 
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 10;
    private float spawnRangeZ = 10;

    private float spawnPosZ = 10;
    private float spawnPosX = 10;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", startDelay, spawnInterval); 
    }
    // Update is called once per frame
    void Update()
    {
       
    }
    void SpawnAnimal()
    {
        int Spawn = Random.Range(1, 4); 
        if (Spawn == 1) 
        {
            SpawnRandomAnimal();
        }
        if (Spawn == 2)
        {
            SpawnRandomLeftAnimal();
        }
        if (Spawn == 3)
        {
            SpawnRandomRightAnimal();
        }
    }
    void SpawnRandomAnimal() 
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length); 

        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos,
            animalPrefabs[animalIndex].transform.rotation); 
        //Spawns animals from up
    }               
    void SpawnRandomRightAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length); 

        Vector3 spawnPos = new Vector3(spawnPosX, 0 , Random.Range(-spawnRangeZ, spawnRangeZ));
        
        Instantiate(animalPrefabs[animalIndex], spawnPos,
            Quaternion.Euler(0, 90, 0)); 
        //Spawns animals from right
    }
    void SpawnRandomLeftAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length); 

        Vector3 spawnPos = new Vector3(spawnPosX, 0 , Random.Range(-spawnRangeZ, spawnRangeZ));
        
        Instantiate(animalPrefabs[animalIndex], spawnPos,
            Quaternion.Euler(0, -90, 0)); 
        //Spawns animals from right
    }
}
    