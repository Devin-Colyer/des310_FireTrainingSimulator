using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfPlayerTakesTooLong : MonoBehaviour {

    public int m_WaitingTimeBeforeHelp;

    public int m_DialogueValue;
    public Dialogue m_DialogueScript;
    bool m_HavePlayedDialogue = false;
    public static bool m_IsLevelCompleted = false;

    void OnEnable()
    {
        StartCoroutine(waiter());

    }

    void OnDisable()
    {
        m_IsLevelCompleted = true;
    }

    //Wait for amount of time to give an help dialogue to the player
    IEnumerator waiter()
    {
 
        yield return new WaitForSeconds(m_WaitingTimeBeforeHelp);
        if (m_IsLevelCompleted == false)
        {
            if (m_HavePlayedDialogue == false)
            {
                Dialogue.m_FDialogueValue = m_DialogueValue;
                m_DialogueScript.PlayDialogue();
                m_HavePlayedDialogue = true;
            }
        }
    }
}
