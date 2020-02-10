Shader "Hidden/SimpleBlur"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
	}
	SubShader
	{
		// No culling or depth
		Cull Off 
		ZWrite Off 
		ZTest Always

		// Horizontal blur.
		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float4 vertex : SV_POSITION;
				float2 uv : TEXCOORD0;
			};

			v2f vert (appdata input)
			{
				v2f output;
				output.vertex = UnityObjectToClipPos(input.vertex);
				output.uv = input.uv;
				return output;
			}
			
			sampler2D _MainTex;
			float2 _BlurSize;

			fixed4 frag (v2f input) : SV_Target
			{
				fixed4 colour = tex2D(_MainTex, input.uv) * 0.38774;
				colour += tex2D(_MainTex, input.uv + float2(_BlurSize.x * 2, 0)) * 0.06136;
				colour += tex2D(_MainTex, input.uv + float2(_BlurSize.x, 0)) * 0.24477;
				colour += tex2D(_MainTex, input.uv + float2(_BlurSize.x * -1, 0)) * 0.24477;
				colour += tex2D(_MainTex, input.uv + float2(_BlurSize.x * -2, 0)) * 0.06136;

				return colour;
			}

			ENDCG
		}

		// Vertical blur.
		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float4 vertex : SV_POSITION;
				float2 uv : TEXCOORD0;
			};

			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = v.uv;
				return o;
			}
			
			sampler2D _MainTex;
			float2 _BlurSize;

			fixed4 frag (v2f input) : SV_Target
			{
				fixed4 colour = tex2D(_MainTex, input.uv) * 0.38774;
				colour += tex2D(_MainTex, input.uv + float2(0, _BlurSize.y * 2)) * 0.06136;
				colour += tex2D(_MainTex, input.uv + float2(0, _BlurSize.y)) * 0.24477;
				colour += tex2D(_MainTex, input.uv + float2(0, _BlurSize.y * -1)) * 0.24477;
				colour += tex2D(_MainTex, input.uv + float2(0, _BlurSize.y * -2)) * 0.06136;

				return colour;
			}

			ENDCG
		}
	}
}
