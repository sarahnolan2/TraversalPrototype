using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostAnim : MonoBehaviour
{
    public float rotationSpeed = 5.0f;
    public float heightDistance = 0.05f;


    // Start is called before the first frame update
    void Start()
    {
        //change the direction of the height distance at every 2 seconds
        //wanted to make it smooth, isn't working as I wanted it to so shelving for later
        //InvokeRepeating("UpDownAnim", 1.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        /*
        if (Time.realtimeSinceStartup % 2 == 0)
        {
            heightDistance = -heightDistance;
        }
        this.transform.Translate(new Vector3(0, heightDistance, 0), Space.Self);*/
    }

    private void FixedUpdate()
    {
        //rotate the boost
        this.transform.Rotate(0, rotationSpeed, 0);
    }

    /*
    void UpDownAnim()
    {
        transform.Translate(Vector3.Lerp(this.transform.position, new Vector3(0, heightDistance, 0), 1));
        //this.transform.Translate(new Vector3(0, heightDistance, 0), Space.Self);
        heightDistance = -heightDistance;
    }*/
}
