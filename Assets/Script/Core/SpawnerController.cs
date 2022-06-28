using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public int maxSpawnBall = 5;
    public int spawnInterval;
    private List<GameObject> templateBall;
    public GameObject ball;

    private float timer;

    void Start()
    {
        templateBall = new List<GameObject>();
        timer = 0;
        GenearateBall();
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnInterval)
        {
            GenearateBall();
            timer -= spawnInterval;
        }
    }
    public void GenearateBall()
    {
        int spawnPos = Random.Range(1, 5);
        if (spawnPos == 1)
        {
            GenearateBallPost(1);
        }
        else if (spawnPos == 2)
        {
            GenearateBallPost(2);
        }
        else if (spawnPos == 3)
        {
            GenearateBallPost(3);
        }
        else if (spawnPos == 4)
        {
            GenearateBallPost(4);
        }
    }

    public void GenearateBallPost(int spawnPoints)
    {
        Vector3 speedSpawned;
        Vector3 spawnPos;
        if (templateBall.Count >= maxSpawnBall)
        {
            return;
        }

        if (spawnPoints == 1)
        {
            speedSpawned = new Vector3(5, 0, 16);
            spawnPos = new Vector3(-5, 4.6f, 2);
            SpawnBall(speedSpawned, spawnPos);
        }
        else if (spawnPoints == 2)
        {
            speedSpawned = new Vector3(-5, 0, 16);
            spawnPos = new Vector3(5, 4.6f, 2);
            SpawnBall(speedSpawned, spawnPos);
        }
        else if (spawnPoints == 3)
        {
            speedSpawned = new Vector3( -5, 0, -2);
            spawnPos = new Vector3(5, 4.6f, 14);
            SpawnBall(speedSpawned, spawnPos);
        }
        else if (spawnPoints == 4)
        {
            speedSpawned = new Vector3(5, 0, -2);
            spawnPos = new Vector3(-5, 4.6f, 14);
            SpawnBall(speedSpawned, spawnPos);
        }
    }

    private void SpawnBall(Vector3 speedSpawned, Vector3 spawnPos)
    {
        GameObject ballSpawned = Instantiate(ball, new Vector3(spawnPos.x, spawnPos.y, spawnPos.z), Quaternion.identity);
        ballSpawned.GetComponent<BallController>().speedBall = speedSpawned;
        templateBall.Add(ballSpawned);
    }
    public void RemoveBall(GameObject ballObject)
    {
        templateBall.Remove(ballObject);
        Destroy(ballObject);
    }
}
