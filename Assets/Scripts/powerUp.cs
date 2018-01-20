using System.Collections;
using UnityEngine;

public class powerUp : MonoBehaviour
{
    public Player player;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("projectile"))
        {
            Pickup(other);
        }

    }

    void Pickup(Collider other)
    {

        if (other.CompareTag("projectile"))
        {
            Debug.Log(player.PowerUp().ToString());

            //Debug.Log(other.GetComponent<Projectile>().shooter.PowerUp());

        }

        else if (other.CompareTag("Player"))
        {
            Debug.Log(player.PowerUp().ToString());
            //Debug.Log(other.GetComponent<Player>().PowerUp());
        }


        Destroy(gameObject);
    }

}
