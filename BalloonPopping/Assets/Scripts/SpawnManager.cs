using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnManager : MonoBehaviour
{


    public GameObject[] balloonPrefabs; // Array of balloon prefabs
    public float startDelay = 0.5f; // Delay before the first balloon spawns
    public float spawnInterval = 1.5f; // Interval between balloon spawns
    public float xRange = 10.0f; // Range for spawning balloons on the X axis
    public float yPos = -5.0f; // Fixed Y position for spawning balloons


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval);
    }

    void SpawnRandomBalloon()
    {

        // Generate a random position within the specified xRange
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange), transform.position.y, transform.position.z);

        // Generate a random index to select a balloon prefab
        int balloonIndex = Random.Range(0, balloonPrefabs.Length);

        // Instantiate the selected balloon prefab at the generated position with no rotation
        Instantiate(balloonPrefabs[balloonIndex], spawnPos, balloonPrefabs[balloonIndex].transform.rotation);
    }
}
