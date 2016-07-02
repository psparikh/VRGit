using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    public GameObject player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    public NavMeshAgent nav;


    void Awake ()
    {
        playerHealth = player.GetComponent <PlayerHealth> ();
        enemyHealth = GetComponent <EnemyHealth> ();
        nav = GetComponent <NavMeshAgent> ();

    }


    void Update ()
    {
        if (playerHealth == null) {

            playerHealth = player.GetComponent<PlayerHealth>();
            enemyHealth = GetComponent<EnemyHealth>();
            nav = GetComponent<NavMeshAgent>();

        }

        if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        {
		    nav.SetDestination (player.transform.position);
        }
        else
        {
           nav.enabled = false;
        }
    }

}
