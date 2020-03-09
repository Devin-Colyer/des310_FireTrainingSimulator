using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ExtinguisherType
{
    FUEL, ELECTRIC, GAS
}

public class ExtinguisherComponent : MonoBehaviour
{
    public ExtinguisherType m_extinguisherType = ExtinguisherType.FUEL;

    private void OnTriggerStay(Collider other)
    {
        // Check if collider is the player.
        if (other.tag == "Player")
        {
            if (Input.GetMouseButtonDown(0))
            {
                // Create new ray in the direct of the mouse.
                Ray l_ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit l_hit;

                // Cast ray towards mouse position.
                if (Physics.Raycast(l_ray, out l_hit))
                {
                    // Check if collider exists.
                    if (l_hit.collider)
                    {
                        // Check if mouse has clicked on this extinguisher.
                        if (l_hit.collider.transform.parent == this.transform)
                        {
                            // Debug output.
                            Debug.Log(m_extinguisherType);
                            
                            // Check if object has a parent.
                            if (this.transform.parent)
                            {
                                // Check if parent is called 'Extinguishers'.
                                if (this.transform.parent.name == "Extinguishers")
                                {
                                    // Enable world model for all extinguishers.
                                    foreach (Transform child in this.transform.parent.transform)
                                    {
                                        child.gameObject.SetActive(true);
                                    }

                                    // Disable world model for this extinguisher.
                                    this.gameObject.SetActive(false);
                                }
                            }

                            // Update player, use fire extinguisher.

                            // Update minigame, change extinguisher.
                            switch(m_extinguisherType)
                            {
                                case ExtinguisherType.FUEL:
                                    break;
                                case ExtinguisherType.ELECTRIC:
                                    break;
                                case ExtinguisherType.GAS:
                                    break;
                            }
                        }
                    }
                }
            }
        }
    }
}
