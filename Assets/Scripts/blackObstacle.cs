using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackObstacle : MonoBehaviour
{

    public Player player;

    void OnTriggerEnter(Collider other)
    {
        //if (other.CompareTag("Player"))
        //{
        //  Pickup(other);
        //}
        //

    }

    void Pickup(Collider playerB)
    {
        playerB.GetComponent<Player>().Damage(5f);
        Debug.Log("You've been hit!");

        Destroy(gameObject);

    }
    //TODO change shit so it's different to Obstacle
}
