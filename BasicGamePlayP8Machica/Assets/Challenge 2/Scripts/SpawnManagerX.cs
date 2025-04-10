using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22.0f;
    private float spawnLimitXRight = 7.0f;
    private float spawnPosY = 30.0f;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("RandomThing", startDelay);
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    void RandomThing ()
    {
        float randomTime = Random.Range(3, 5);
        SpawnRandomBall();
        Invoke("RandomThing", randomTime);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        int randomBallIndex = Random.Range(0, ballPrefabs.Length);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        int ballIndex = Random.Range(0, ballPrefabs.Length);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randomBallIndex], spawnPos, ballPrefabs[randomBallIndex].transform.rotation);
    }

}
