using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastGrabbedObjectHit : MonoBehaviour {

    public float lastGrabbedObjectVelocity;

    GameObject g_lastGrabbedObject;

    float kineticEnergy;
    public float objectMass;
    public float velocity;


    //To delete, it's just to have something to put on If object hit something
    public bool test;




    void Start()
    {
        g_lastGrabbedObject = null;
    }



    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("HitSomething");
    }



    void Update()
    {
        //Check if there are a throwed object
        if (gameObject==g_lastGrabbedObject)
        {


            //If this object hit something
            if (test)
            {
                //calucate it's KineticEnergy to mesure the power of it's impact
                Rigidbody rb = g_lastGrabbedObject.GetComponent<Rigidbody>();
                Vector3 v3Velocity = rb.velocity;
                kineticEnergy = .5f * objectMass * velocity * velocity;
                Debug.Log(kineticEnergy);

            }
            
        }
        
    }

}
