using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsPlayerInRange_Finder : MonoBehaviour {

    public GameObject m_Player;

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            float l_Distance = Vector3.Distance(m_Player.transform.position, this.transform.position);
            float l_Radius = this.GetComponent<SphereCollider>().radius;
            int l_DistToTriggerPercentage = (int)((l_Distance / l_Radius) * 100);
            this.GetComponentInParent<HazardPopupController>().SetHazardFinderLevel(l_DistToTriggerPercentage);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        this.GetComponentInParent<HazardPopupController>().LeaveHazardArea();
    }
}
