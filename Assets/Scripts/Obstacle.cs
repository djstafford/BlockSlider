using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Player playerP;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }

        if (other.CompareTag("projectile"))
        {
            Debug.Log(playerP.ScoreObstacle());
            Destroy(gameObject);


        }
    }

    void Pickup(Collider player)
    {
        player.GetComponent<Player>().Damage(5f);
        Debug.Log("You've been hit!");

        Destroy(gameObject);

    }


}
