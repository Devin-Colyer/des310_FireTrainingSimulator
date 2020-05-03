using UnityEngine;
using System.Diagnostics;

public class HazardFinder : MonoBehaviour
{
    public GameObject m_player;
    private Transform m_hazardPopup;
    public GameObject m_levelExit;
    public GameObject[] m_hazards;
    [Range(0, 100)] public float m_maxDistance = 10;

    // VoiceOverPart
    public static int m_HazardFinderDialogueValue;
    public Dialogue m_DialogueScript;
    public static bool m_HavePlayedDialogue = false;
    public bool m_NeedToPlayCompletedMinigameDialogue = false;
    bool m_HavePlayedCompletedHazardDialogue = false;
    public bool m_NeedToPlayCompletedHazardDialogue = false;
    public int m_CompletedHazardDialogueValue = 0;




    void Start()
    {
        // Check if player exists.
        if (m_player)
        {
            // Find hazard popup in player.
            m_hazardPopup = m_player.transform.Find("Hazard Popup");
        }
    }

	// Update is called once per frame
	void Update ()
    {
        if (m_hazards.Length <= 0)
        {
            // Safety check, makes sure there are hazards in the scene.
            m_hazardPopup.GetComponent<TextMesh>().text = "";
            return;
        }

        // Initialise min distance, default to maximum range.
        float l_minDistance = m_maxDistance;

        // Initialise hazard counter, default to zero.
        int l_numHazards = 0;

        foreach (GameObject hazard in m_hazards)
        {
            // Check if hazard is broken (check if active in hirearchy, count hazards in inactive rooms).
            if (hazard.transform.Find("Broken").gameObject.activeSelf)
            {
                // Increment number of hazards.
                l_numHazards++;
                Debugger.Break();

                // Calculate distance to player.
                float l_distance = Vector3.Distance(hazard.transform.position, m_player.transform.position);

                // Check if hazard is closer than current closest hazard.
                if (l_distance < l_minDistance)
                {
                    // Update min distance and closest hazard.
                    l_minDistance = l_distance;
                }
            }
        }

        // Debug output.
        ///Debug.Log(l_numHazards + "/" + m_hazards.Length);

        if (l_numHazards == 0)
        {
            // All hazards have been dealt with.
            m_hazardPopup.GetComponent<TextMesh>().text = "";

            if (m_levelExit)
            {
                // Check if exit is closed.
                if (m_levelExit.transform.Find("Closed").gameObject.activeSelf)
                {
                    // Play dialogue.

                    // Open level exit.
                    m_levelExit.transform.Find("Open").gameObject.SetActive(true);
                    m_levelExit.transform.Find("Closed").gameObject.SetActive(false);
                }
            }

            // VoiceOverPart
            if (m_NeedToPlayCompletedHazardDialogue)
            {
                if (m_HavePlayedCompletedHazardDialogue == false)
                {
                    Dialogue.m_FDialogueValue = m_CompletedHazardDialogueValue;
                    m_DialogueScript.PlayDialogue();
                    m_HavePlayedCompletedHazardDialogue = true;
                }
            }
        }
        else
        {
            // Calculate percentage distance from hazard.
            float l_percentageDistance = (l_minDistance / m_maxDistance) * 100.0f;

            // Update hazard popup using closest hazard.
            if (l_percentageDistance < 33)
            {
                m_hazardPopup.GetComponent<TextMesh>().text = "!!!";
                if (m_NeedToPlayCompletedMinigameDialogue == true)
                {
                    if (m_HavePlayedDialogue == false)
                    {
                        Dialogue.m_FDialogueValue = m_HazardFinderDialogueValue;
                        m_DialogueScript.PlayDialogue();
                        m_HavePlayedDialogue = true;
                    }
                }
            }
            else if (l_percentageDistance < 66)
            {
                m_hazardPopup.GetComponent<TextMesh>().text = "!!";
            }
            else if (l_percentageDistance < 99)
            {
                m_hazardPopup.GetComponent<TextMesh>().text = "!";
            }
            else
            {
                m_hazardPopup.GetComponent<TextMesh>().text = "";
            }
        }
    }
}
