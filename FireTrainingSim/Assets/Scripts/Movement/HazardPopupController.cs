using UnityEngine;

public class HazardPopupController : MonoBehaviour {

    public GameObject m_HazardPopup;
    public GameObject m_Player;

    // Update is called once per frame
    void Update()
    {
        m_HazardPopup.GetComponent<Transform>().SetPositionAndRotation(new Vector3(m_Player.transform.position.x, 9.25f, m_Player.transform.position.z), m_HazardPopup.transform.rotation);
    }

    public void SetHazardFinderLevel(int in_DistToTriggerPercentage)
    {
        if (in_DistToTriggerPercentage < 50)
        {
            m_HazardPopup.GetComponent<TextMesh>().text = "!!!";
        }
        else if (in_DistToTriggerPercentage < 75)
        {
            m_HazardPopup.GetComponent<TextMesh>().text = "!!";
        }
        else
        {
            m_HazardPopup.GetComponent<TextMesh>().text = "!";
        }
    }
    public void LeaveHazardArea()
    {
        m_HazardPopup.GetComponent<TextMesh>().text = "";
    }
}
