using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(SteamVR_TrackedController))]

public class MenuController : MonoBehaviour {

    // Use this for initialization
    SteamVR_TrackedController controller;
    public UnityEngine.UI.Text text;
    public UnityEngine.Light light1;
    public UnityEngine.Light light2;
    float timerCount = 10f;
    public float lightChange;

    private void Initialize() {

        controller = GetComponent<SteamVR_TrackedController>();

    }

	void Start () {

        Initialize();

	
	}

    void Reset() {

        Initialize();
        controller.SetDeviceIndex(1);


    }
	
	// Update is called once per frame
	void Update () {
        string firstText = "Starting in ";

        light1.intensity += lightChange;
        light2.intensity += lightChange;

        text.text = firstText + "10";

        timerCount -= Time.deltaTime;

        if (timerCount < 0) {
            text.text = firstText + "0";
            SceneManager.LoadScene("Play");
        }
        else if (timerCount < 1)
        {
            text.text = firstText + "1";
        }
        else if (timerCount < 2)
        {
            text.text = firstText + "2";
        }
        else if (timerCount < 3)
        {
            text.text = firstText + "3";
        }
        else if (timerCount < 4)
        {
            text.text = firstText + "4";
        }
        else if (timerCount < 5)
        {
            text.text = firstText + "5";
        }
        else if (timerCount < 6)
        {
            text.text = firstText + "6";
        }
        else if (timerCount < 7)
        {
            text.text = firstText + "7";
        }
        else if (timerCount < 8)
        {
            text.text = firstText + "8";
        }
        else if (timerCount < 9)
        {
            text.text = firstText + "9";
        }
    }
}
