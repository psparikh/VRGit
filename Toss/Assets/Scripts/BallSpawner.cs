using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

    public GameObject ball;
    public static int ballsInPlay = 0;
    public static int ballsInLevel = 8;
    public static int totalBallsDestroyed = 0;
    public static int totalBallsSpawned;
    public float timeSinceLastBallSpawned;
    public float timeBetweenBallSpawns = 0.6f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (totalBallsSpawned < ballsInLevel) {

            if (timeSinceLastBallSpawned < Time.time)
            {
                if (ballsInPlay < 2)
                {
                    ballsInPlay++;
                    totalBallsSpawned++;
                    SpawnBall();
                    timeSinceLastBallSpawned = Time.time + timeBetweenBallSpawns;

                }
            }
        }


	
	}

    void SpawnBall()
    {
        Instantiate(ball, transform.position, Quaternion.identity);
    }
}
