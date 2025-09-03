        using System.Collections; // Required for Coroutines
        using System.Collections.Generic;
        using UnityEngine;

        public class PrefabSpawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float spawnInterval = 2f; // Time between spawns

    public Quaternion spawnRotation; // Rotation for spawned prefab

    public float destroyDelay = 20.0f; // Time after which the spawned prefab will be destroyed

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true) // Continuous spawning
        {
            GameObject spawnedObject = Instantiate(prefabToSpawn, transform.position, spawnRotation);
            yield return new WaitForSeconds(spawnInterval);
            Destroy(spawnedObject, destroyDelay); // Destroy after delay
        }
    }
}