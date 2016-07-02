using UnityEngine;
using System.Collections;

public class BallVariables : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (transform.position.y < -30) {

            Destroy(gameObject);
            BallSpawner.ballsInPlay--;
            BallSpawner.totalBallsDestroyed++;

        }
	}
}
