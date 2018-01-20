using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {
   
    public Rigidbody rb;

    public float forwardForce = 50f;

    public float sidewayForce = 1500f;

    public float jumpForce = 10000f;

    public bool isGrounded;





	// Use this for initialization
	void FixedUpdate () 


        
    {
		rb.AddForce(0, 0, forwardForce);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w") && isGrounded == true)
        {
            rb.AddForce(Vector3.up * 550.0f);
            isGrounded = false;
        }


    }
	
    void OnCollisionEnter()

    {
        isGrounded = true; 
    }
}
