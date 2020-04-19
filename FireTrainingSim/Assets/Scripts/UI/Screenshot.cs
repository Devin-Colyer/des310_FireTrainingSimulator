using UnityEngine;
using System.Collections;

public class Screenshot : MonoBehaviour
{
    public int m_superSize = 1;

    void Update()
    {
        if(Input.GetKeyDown("f12"))
        {
            ScreenCapture.CaptureScreenshot(string.Format("Screenshots/screenshot_{0}.png", System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")), m_superSize);
        }
    }
}