using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; // Array de animales
    private int animalIndex;  // �ndice del array de animales

    private float spawnRangeX = 14f;
    private float spawnPosZ = 15f;

    public float startDelay = 1.5f;  //Determina qu� tiempo tiene el jugador
    public float spawnInterial = 2f; //Determina cada cu�nto sale el animal

    private void SpawnRandomAnimal() //Funci�n que determina la aletoriedad de los tipos de animales que van apareciendo en una posici�n aleatoria
    {
        animalIndex = Random.Range(0, animalPrefabs.Length); //�ndice aleatorio
        Instantiate(animalPrefabs[animalIndex], RandomSpawnPos(), animalPrefabs[animalIndex].transform.rotation);
    }

    private Vector3 RandomSpawnPos() //Vector aleatorio que determina una posicion aleatoria para los prefabs-animales
    {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        return new Vector3(randomX, 0, spawnPosZ);
    }

    private void Start() // Llama peri�dicamente a la funci�n SpawnRnadomAnimal
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterial);
    }
}
