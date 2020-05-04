using UnityEngine;

public class LastGrabbedObjectHit : MonoBehaviour {

    public float m_lastGrabbedObjectVelocity;

    GameObject m_lastGrabbedObject;

    float m_kineticEnergy;
    public float m_objectMass;
    public float m_velocity;


    //To delete, it's just to have something to put on If object hit something
    public bool test;




    void Start()
    {
        m_lastGrabbedObject = null;
    }

    void Update()
    {
        //Check if there are a throwed object
        if (gameObject== m_lastGrabbedObject)
        {


            //If this object hit something
            if (test)
            {
                //calucate it's KineticEnergy to mesure the power of it's impact
                Rigidbody rb = m_lastGrabbedObject.GetComponent<Rigidbody>();
                Vector3 v3Velocity = rb.velocity;
                m_kineticEnergy = .5f * m_objectMass * m_velocity * m_velocity;
                Debug.Log(m_kineticEnergy);

            }
            
        }
        
    }

}
