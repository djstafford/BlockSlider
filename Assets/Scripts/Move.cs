using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject gameobject;
    Vector3 temp;
    Vector3 startPoint;
    public Vector3 endPoint;
    public float timeToReachTarget;
    float t;
    // Update is called once per frame


    private void Start()
    {
        startPoint = gameobject.transform.position;
    }



    void Update()
    {
        t += Time.deltaTime / timeToReachTarget;
        gameobject.transform.position = Vector3.Lerp(startPoint, endPoint, t);

        if (t >= timeToReachTarget)
        {
            t = 0;

            temp = startPoint;
            startPoint = endPoint;
            endPoint = temp;

        }



    }

}
