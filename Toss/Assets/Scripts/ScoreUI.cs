using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour {

    // Use this for initialization
    public Text scoreText;
	void Start () {

        scoreText = GetComponent<Text>();
	
	}
	
	// Update is called once per frame
	void Update () {

        scoreText.text = "Score: " + GameManager.score;
	}
}
