using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardFinder : MonoBehaviour
{
    public GameObject m_player;
    private Transform g_hazardPopup;
    public GameObject m_levelExit;
    public GameObject[] m_hazards;
    [Range(0, 100)] public float m_maxDistance = 10;

    // VoiceOverPart
    public static int HazardFinder_DialogueValue;
    public Dialogue DialogueScript;
    public static bool HavePlayedDialogue = false;
    public bool NeedToPlayCompletedMinigameDialogue = false;
    bool HavePlayedCompletedHazardDialogue = false;
    public bool NeedToPlayCompletedHazardDialogue = false;
    public int CompletedHazardDialogueValue = 0;




    void Start()
    {
        // Check if player exists.
        if (m_player)
        {
            // Find hazard popup in player.
            g_hazardPopup = m_player.transform.Find("Hazard Popup");
        }
    }

	// Update is called once per frame
	void Update ()
    {
        if (m_hazards.Length <= 0)
        {
            // Safety check, makes sure there are hazards in the scene.
            g_hazardPopup.GetComponent<TextMesh>().text = "";
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
            g_hazardPopup.GetComponent<TextMesh>().text = "";


            // VoiceOverPart
            if (NeedToPlayCompletedHazardDialogue)
            {
                if (HavePlayedCompletedHazardDialogue == false)
                {
                    Dialogue.F_DialogueValue = CompletedHazardDialogueValue;
                    DialogueScript.PlayDialogue();
                    HavePlayedCompletedHazardDialogue = true;
                }

            }


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
        }
        else
        {
            // Calculate percentage distance from hazard.
            float l_percentageDistance = (l_minDistance / m_maxDistance) * 100.0f;

            // Update hazard popup using closest hazard.
            if (l_percentageDistance < 33)
            {
                g_hazardPopup.GetComponent<TextMesh>().text = "!!!";
                if (NeedToPlayCompletedMinigameDialogue == true)
                {
                    if (HavePlayedDialogue == false)
                    {
                        Dialogue.F_DialogueValue = HazardFinder_DialogueValue;
                        DialogueScript.PlayDialogue();
                        HavePlayedDialogue = true;
                    }
                }
            }
            else if (l_percentageDistance < 66)
            {
                g_hazardPopup.GetComponent<TextMesh>().text = "!!";
            }
            else if (l_percentageDistance < 99)
            {
                g_hazardPopup.GetComponent<TextMesh>().text = "!";
            }
            else
            {
                g_hazardPopup.GetComponent<TextMesh>().text = "";
            }
        }
    }
}
