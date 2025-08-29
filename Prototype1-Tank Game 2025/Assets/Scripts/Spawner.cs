        using System.Collections; // Required for Coroutines
        using System.Collections.Generic;
        using UnityEngine;

        public class PrefabSpawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float spawnInterval = 2f; // Time between spawns

    public Quaternion spawnRotation; // Rotation for spawned prefab

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true) // Continuous spawning
        {
            Instantiate(prefabToSpawn, transform.position, spawnRotation);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}