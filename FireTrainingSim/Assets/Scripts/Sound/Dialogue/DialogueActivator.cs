using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueActivator : MonoBehaviour {

    public int DialogueValue;
    public Dialogue DialogueScript;
    bool HavePlayedDialogue = false;

    // Avoid the dialogue to be played at first wake of the scene, but allow when minigame is completed
    public IfPlayerTakesTooLong IfPlayerTakesTooLongScript;
    public bool NeedLevelCompletedToPlay = false;

    void OnEnable () {
        if (NeedLevelCompletedToPlay == false)
        {
            if (HavePlayedDialogue == false)
            {
                Dialogue.F_DialogueValue = DialogueValue;
                DialogueScript.PlayDialogue();
                HavePlayedDialogue = true;
            }
        }

        else if (NeedLevelCompletedToPlay)
        {
            if (IfPlayerTakesTooLong.IsLevelCompleted)
            {
                if (HavePlayedDialogue == false)
                {
                    Dialogue.F_DialogueValue = DialogueValue;
                    DialogueScript.PlayDialogue();
                    HavePlayedDialogue = true;
                }
                IfPlayerTakesTooLong.IsLevelCompleted = false;
            }
        }

    }
}
