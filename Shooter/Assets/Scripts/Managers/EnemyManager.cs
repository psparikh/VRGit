using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject enemy;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;
    public GameObject playerChosen;



    void Start ()
    {
        InvokeRepeating ("Spawn", spawnTime, spawnTime);
    }


    void Spawn ()
    {
        if(playerHealth.currentHealth <= 0f)
        {
            return;
        }

        int spawnPointIndex = Random.Range (0, spawnPoints.Length);


       GameObject go = (GameObject) Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        EnemyMovement em = go.GetComponent<EnemyMovement>();
        em.player = playerChosen;

        EnemyAttack ea = go.GetComponent<EnemyAttack>();
        ea.player = playerChosen;

        em.enabled = true;
        ea.enabled = true;



    }
}
