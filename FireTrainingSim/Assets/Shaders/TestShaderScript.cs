using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class TestShaderScript : MonoBehaviour
{
    public Shader testShader;

    void OnEnable()
    {
        if (testShader)
        {
            this.GetComponent<Camera>().SetReplacementShader(testShader, "RenderType");
        }
    }

    void OnDisable()
    {
        this.GetComponent<Camera>().ResetReplacementShader();
    }
}
