using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

    // Use this for initialization

    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Ball")
        {

            GameManager.score += 5;
            Destroy(col.gameObject);
            BallSpawner.ballsInPlay--;
            BallSpawner.totalBallsDestroyed++;

        }

    }
}
