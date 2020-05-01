using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfPlayerTakesTooLong : MonoBehaviour {

    public int WaitingTimeBeforeHelp;

    public int DialogueValue;
    public Dialogue DialogueScript;
    bool HavePlayedDialogue = false;
    public static bool IsLevelCompleted = false;

    void OnEnable()
    {
        StartCoroutine(waiter());

    }

    void OnDisable()
    {
        IsLevelCompleted = true;
    }

    //Wait for amount of time to give an help dialogue to the player
    IEnumerator waiter()
    {
 
        yield return new WaitForSeconds(WaitingTimeBeforeHelp);
        if (IsLevelCompleted == false)
        {
            if (HavePlayedDialogue == false)
            {
                Dialogue.F_DialogueValue = DialogueValue;
                DialogueScript.PlayDialogue();
                HavePlayedDialogue = true;
            }
        }
    }
}
