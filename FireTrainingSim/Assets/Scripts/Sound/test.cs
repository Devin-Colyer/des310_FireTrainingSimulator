using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    public int UniqueValue;
    public int[] ArrayValues = new int[10];

    public DialogueStateControl m_dialogueStateControl = DialogueStateControl.DONTPLAY;
    public enum DialogueStateControl
    {
        DONTPLAY,
        PLAYNUMBER,
        PLAYDIFFERENT
    }

    

    void Start()
    {
        foreach (int itr in ArrayValues)
        {
            if (UniqueValue == itr)
            {
                Debug.Log("Success");
               m_dialogueStateControl = DialogueStateControl.PLAYNUMBER;
                if (m_dialogueStateControl == DialogueStateControl.PLAYNUMBER)
                {
                    Debug.Log("Work in local");
                }
            }
        }

    }
    void Update()
    {
        if (m_dialogueStateControl == DialogueStateControl.PLAYNUMBER)
        {
            Debug.Log("Work in public");
        }
    }
}
