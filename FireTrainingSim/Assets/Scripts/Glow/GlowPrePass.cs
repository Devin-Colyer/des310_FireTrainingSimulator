using UnityEngine;

[RequireComponent(typeof(Camera))]
public class GlowPrePass : MonoBehaviour
{
	private static RenderTexture m_prePassTexture;
	private static RenderTexture m_blurTexture;

	private Material m_blurMaterial;

	void OnEnable()
	{
        Camera l_camera = GetComponent<Camera>();
        Shader l_glowReplacementShader = Shader.Find("Hidden/GlowReplacement");

        // Initialise render textures.
        m_prePassTexture = new RenderTexture(Screen.width, Screen.height, 24);
        //g_prePassTexture.antiAliasing = QualitySettings.antiAliasing;
        m_blurTexture = new RenderTexture(Screen.width >> 1, Screen.height >> 1, 0);

        // Set new render target, apply replacement shader.
        l_camera.targetTexture = m_prePassTexture;
        l_camera.SetReplacementShader(l_glowReplacementShader, "Glowable");

        // Set global textures.
		Shader.SetGlobalTexture("_GlowPrePassTex", m_prePassTexture);
		Shader.SetGlobalTexture("_GlowBlurredTex", m_blurTexture);

        // Create blur material.
        m_blurMaterial = new Material(Shader.Find("Hidden/SimpleBlur"));
        m_blurMaterial.SetVector("_BlurSize", new Vector2(m_blurTexture.texelSize.x * 1.5f, m_blurTexture.texelSize.y * 1.5f));
	}

	void OnRenderImage(RenderTexture src, RenderTexture dst)
	{
		Graphics.Blit(src, dst);

		Graphics.SetRenderTarget(m_blurTexture);
		GL.Clear(false, true, Color.clear);

		Graphics.Blit(src, m_blurTexture);
		
		for (int i = 0; i < 4; i++)
		{
			var temp = RenderTexture.GetTemporary(m_blurTexture.width, m_blurTexture.height);
			Graphics.Blit(m_blurTexture, temp, m_blurMaterial, 0);
			Graphics.Blit(temp, m_blurTexture, m_blurMaterial, 1);
			RenderTexture.ReleaseTemporary(temp);
		}
	}
}
