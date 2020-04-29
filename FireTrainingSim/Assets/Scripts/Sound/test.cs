//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class test : MonoBehaviour
//{

//    public int UniqueValue;
//    public int[] ArrayValues = new int[10];
//    public enum DialogueStateControl
//    {
//        DONTPLAY,
//        PLAYNUMBER,
//        PLAYDIFFERENT
//    }

//    void Start()
//    {
//        foreach (int itr in ArrayValues)
//        {
//            if (UniqueValue == itr)
//            {
//                Debug.Log("Success");
//                DialogueStateControl _DialogueStateControl = DialogueStateControl.PLAYNUMBER;
//                if (_DialogueStateControl == DialogueStateControl.PLAYNUMBER)
//                {
//                    Debug.Log("Work in local");
//                }
//            }
//        }

//    }
//    void Update()
//    {
//        if (_DialogueStateControl == DialogueStateControl.PLAYNUMBER)
//        {
//            Debug.Log("Work in public");
//        }
//    }
//}
