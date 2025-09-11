using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Balloon_Spawner : MonoBehaviour
{

    public GameObject balloonPrefab; // Reference to the balloon prefab
    public float spawnInterval = 2.0f; // Time interval between spawns
    public float spawnRange = 13.0f; // Range within which balloons can spawn


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnBalloons());
    }

    // Update is called once per frame
   IEnumerator SpawnBalloons()
        {
            while (true)
            {
                float randomX = transform.position.x + Random.Range(-spawnRange, spawnRange);
                Vector3 spawnPosition = new Vector3(randomX, transform.position.y, transform.position.z);

                Instantiate(balloonPrefab, spawnPosition, transform.rotation);
                yield return new WaitForSeconds(spawnInterval);
            }
        }
}
        

