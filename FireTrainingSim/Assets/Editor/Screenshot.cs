using UnityEngine;
using UnityEditor;
using System.Collections;

public class Screenshot : ScriptableObject
{
    [MenuItem("Custom/Take Screenshot %F12")]
    static void TakeScreenshot()
    {
        string filename = "Screenshots/screenshot_" + System.DateTime.Now.ToString("yy-MM-dd_HH-mm-ss") + ".png";
        ScreenCapture.CaptureScreenshot(filename, 2);
    }
}