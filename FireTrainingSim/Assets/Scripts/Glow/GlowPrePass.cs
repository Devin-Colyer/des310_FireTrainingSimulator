using UnityEngine;

[RequireComponent(typeof(Camera))]
public class GlowPrePass : MonoBehaviour
{
	private static RenderTexture g_prePassTexture;
	private static RenderTexture g_blurTexture;

	private Material g_blurMaterial;

	void OnEnable()
	{
        Camera l_camera = GetComponent<Camera>();
        Shader l_glowReplacementShader = Shader.Find("Hidden/GlowReplacement");

        // Initialise render textures.
        g_prePassTexture = new RenderTexture(Screen.width, Screen.height, 24);
        //g_prePassTexture.antiAliasing = QualitySettings.antiAliasing;
        g_blurTexture = new RenderTexture(Screen.width >> 1, Screen.height >> 1, 0);

        // Set new render target, apply replacement shader.
        l_camera.targetTexture = g_prePassTexture;
        l_camera.SetReplacementShader(l_glowReplacementShader, "Glowable");

        // Set global textures.
		Shader.SetGlobalTexture("_GlowPrePassTex", g_prePassTexture);
		Shader.SetGlobalTexture("_GlowBlurredTex", g_blurTexture);

        // Create blur material.
        g_blurMaterial = new Material(Shader.Find("Hidden/SimpleBlur"));
        g_blurMaterial.SetVector("_BlurSize", new Vector2(g_blurTexture.texelSize.x * 1.5f, g_blurTexture.texelSize.y * 1.5f));
	}

	void OnRenderImage(RenderTexture src, RenderTexture dst)
	{
		Graphics.Blit(src, dst);

		Graphics.SetRenderTarget(g_blurTexture);
		GL.Clear(false, true, Color.clear);

		Graphics.Blit(src, g_blurTexture);
		
		for (int i = 0; i < 4; i++)
		{
			var temp = RenderTexture.GetTemporary(g_blurTexture.width, g_blurTexture.height);
			Graphics.Blit(g_blurTexture, temp, g_blurMaterial, 0);
			Graphics.Blit(temp, g_blurTexture, g_blurMaterial, 1);
			RenderTexture.ReleaseTemporary(temp);
		}
	}
}
