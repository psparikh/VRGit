using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SteamVR_TrackedController))]
public class TimeController : MonoBehaviour {

    // Use this for initialization
    public float timeScaleRate;
    private SteamVR_TrackedController controller;

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

        float dTimeScale = timeScaleRate * Time.unscaledDeltaTime;
        if (controller.gripped) { dTimeScale *= -1;  }
        Time.timeScale = Mathf.Clamp01(Time.timeScale + dTimeScale);
	
	}
}
