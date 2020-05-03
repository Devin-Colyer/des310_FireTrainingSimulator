using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class GlowComposite : MonoBehaviour
{
	[Range (0, 10)]
	public float m_Intensity = 2;

	private Material m_compositeMaterial;

	void OnEnable()
	{
        m_compositeMaterial = new Material(Shader.Find("Hidden/GlowComposite"));
    }

	void OnRenderImage(RenderTexture src, RenderTexture dst)
	{
        m_compositeMaterial.SetFloat("_Intensity", m_Intensity);
        Graphics.Blit(src, dst, m_compositeMaterial, 0);
	}
}
