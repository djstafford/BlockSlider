using System.Collections;
using UnityEngine;

public class projectileCollision : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "target")
        {
            Destroy(gameObject);
            Debug.Log("You hit an object!");

        }

        else if (other.gameObject.tag == "blackObstacle")
        {
            Destroy(gameObject);
            Debug.Log("You hit a blackObstical");
        }



    }



}