using UnityEngine;

public class playerCollision : MonoBehaviour
{

    public float damage = 10f;






    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "target")
        {
            Pickup(collision.gameObject);
        }
    }

    void Pickup(GameObject obstacle)
    {
        Debug.Log("You've been hit!");

    }

}
