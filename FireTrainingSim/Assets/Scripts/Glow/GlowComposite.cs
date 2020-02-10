using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class GlowComposite : MonoBehaviour
{
	[Range (0, 10)]
	public float Intensity = 2;

	private Material g_compositeMaterial;

	void OnEnable()
	{
        g_compositeMaterial = new Material(Shader.Find("Hidden/GlowComposite"));
    }

	void OnRenderImage(RenderTexture src, RenderTexture dst)
	{
        g_compositeMaterial.SetFloat("_Intensity", Intensity);
        Graphics.Blit(src, dst, g_compositeMaterial, 0);
	}
}
