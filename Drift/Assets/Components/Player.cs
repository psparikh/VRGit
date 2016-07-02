using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]

public class Player : MonoBehaviour {

    private Rigidbody rb;
    public Transform head;
    public float movementSpeed = 1;

	// Use this for initialization
	void Start () {
        Initialize();
	}

    private void Initialize() {

        rb = GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void Update () {

        Vector3 direction = head.forward;
        rb.velocity = movementSpeed * direction;
	
	}

    void Reset() {

        Initialize();
        rb.useGravity = false;
        rb.freezeRotation = true;

    }

    void OnCollisionEnter(Collision col) {

        if (col.gameObject.CompareTag("Goal")) {

            SceneManager.LoadScene("Main");
            return;
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
