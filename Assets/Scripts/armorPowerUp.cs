using System.Collections;
using UnityEngine;

public class armorPowerUp : MonoBehaviour
{

    public Player player;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("projectile"))

            Pickup(other);

    }

    void Pickup(Collider other)
    {
        if (other.CompareTag("projectile"))

        {
            player.ArmorPowerUp();

        }

        else if (other.CompareTag("Player"))
        {
            player.ArmorPowerUp();
        }

        Destroy(gameObject);

    }
}
