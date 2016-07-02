using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GrabBall : MonoBehaviour {

    // Use this for initialization
    public SteamVR_TrackedObject controller;
    private GameObject selectedObject;
    private GameObject grabbedObject;
    bool timeStart = false;
    float timer;

	void Start () {
	
	}

    // Update is called once per frame

    void Update() {

        if (timeStart)
        {

            timer += Time.deltaTime;
        }

        if (timer >= 5) {

            SceneManager.LoadScene("Bowling");
            timeStart = false;
        }
    }
    void FixedUpdate() {

        SteamVR_Controller.Device device = SteamVR_Controller.Input((int)controller.index);

        if (grabbedObject != null) {

            grabbedObject.transform.position = this.gameObject.transform.position;
        }

        if ((selectedObject != null && grabbedObject == null) && device.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger))
        {

            grabbedObject = selectedObject;
            grabbedObject.transform.position = this.gameObject.transform.position;
        }
        else if (grabbedObject != null && device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger)) {

            var rigidbody = grabbedObject.GetComponent<Rigidbody>();
            rigidbody.velocity = grabbedObject.transform.TransformVector(device.velocity * 4);

            rigidbody.angularVelocity = grabbedObject.transform.TransformVector(device.angularVelocity * 4);
            rigidbody.maxAngularVelocity = rigidbody.angularVelocity.magnitude;

            selectedObject = null;
            grabbedObject = null;

            timeStart = true;

        }

    }

    void OnTriggerEnter(Collider other) {

        selectedObject = other.gameObject;

    }

    void OnTriggerExit(Collider other) {

        if (selectedObject == other.gameObject) {

            selectedObject = null;

        }

    }


}
