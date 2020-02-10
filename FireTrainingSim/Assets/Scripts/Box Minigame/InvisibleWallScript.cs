using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleWallScript : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        GameObject l_clutter = GameObject.Find("Moveable Clutter");

        if (l_clutter)
        {
            // Debug output.
            ///Debug.Log("Found moveable clutter.");

            // Ignore collision with clutter objects.
            foreach (Transform child in l_clutter.transform)
            {
                Physics.IgnoreCollision(child.GetComponent<Collider>(), this.GetComponent<Collider>(), true);

                // Debug output.
               /// Debug.Log("Ignored collision between " + child.name + " and " + this.name);
            }
        }
    }
}
