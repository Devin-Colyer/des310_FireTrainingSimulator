using UnityEngine;

public class DialogueActivator : MonoBehaviour {

    public int m_DialogueValue;
    public Dialogue m_DialogueScript;
    bool m_HavePlayedDialogue = false;

    // Avoid the dialogue to be played at first wake of the scene, but allow when minigame is completed
    public IfPlayerTakesTooLong m_IfPlayerTakesTooLongScript;
    public bool m_NeedLevelCompletedToPlay = false;

    void OnEnable () {
        if (m_NeedLevelCompletedToPlay == false)
        {
            if (m_HavePlayedDialogue == false)
            {
                Dialogue.m_FDialogueValue = m_DialogueValue;
                m_DialogueScript.PlayDialogue();
                m_HavePlayedDialogue = true;
            }
        }

        else if (m_NeedLevelCompletedToPlay)
        {
            if (IfPlayerTakesTooLong.m_IsLevelCompleted)
            {
                if (m_HavePlayedDialogue == false)
                {
                    Dialogue.m_FDialogueValue = m_DialogueValue;
                    m_DialogueScript.PlayDialogue();
                    m_HavePlayedDialogue = true;
                }
                IfPlayerTakesTooLong.m_IsLevelCompleted = false;
            }
        }

    }
}
