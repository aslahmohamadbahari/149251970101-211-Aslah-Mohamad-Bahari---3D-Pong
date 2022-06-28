using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] int minSpawnDelay = 1;
    [SerializeField] int maxSpawnDelay = 5;
    [SerializeField] List<BallController> spawnerBall;
    [SerializeField] int maxSpawn;
    [SerializeField] float speedBall;

    bool spawn = true;

    // Start is called before the first frame update

    /*IEnumerator Start()
    {
        if (spawn >= maxSpawn)
        {

        }
            yield return new WaitForSeconds(
                Random.Range(minSpawnDelay, maxSpawnDelay));
            spawnBall();
    }*/

    private void spawnBall()
    {
        if (spawnerBall.Count >= 5)
        {
            return;
        }
        var spawnerIndex = Random.Range(0, spawnerBall.Count);

        movementBall(spawnerBall[spawnerIndex]);

    }

    private void movementBall(BallController Ball)
    {
        BallController ball = Instantiate(
                       Ball, transform.position,
                       Quaternion.identity) as BallController;
        ball.GetComponent<Rigidbody>().velocity = new Vector3(10, 10);
    }

    public void stopSpawning()
    {
        if (spawnerBall.Count >= 5)
        {
            spawn = false;
        }
    }
}
