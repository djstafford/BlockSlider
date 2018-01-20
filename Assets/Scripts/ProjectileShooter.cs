using System.Collections;
using UnityEngine;
using System.Threading;

public class ProjectileShooter : MonoBehaviour
{
    public float bulletSpeed = 100f;

    GameObject prefab;

    void Start()
    {
        prefab = Resources.Load("projectile") as GameObject;

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            GameObject projectile = Instantiate(prefab) as GameObject;
            projectile.transform.position = transform.position;
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(0f, 0f, 100f);

            Destroy(projectile, 1.5f);
            Thread.Sleep(20);
        }




    }

    public float PowerUp()
    {
        return GetComponent<Player>().PowerUp();
    }

}
