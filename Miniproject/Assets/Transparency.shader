Shader "kameraReflect"

//Struktur af koden er fra: https://en.wikibooks.org/wiki/Cg_Programming/Unity/Mirrors
//TO-DO Kommenter og skriv koden fra bunden

{
	Properties
	{
		_LeftTex("kameraTexture", 2D)="_"{}
	}
	
	SubShader
	{
	  Tags { "Queue" = "Transparent" }

		Pass
		{
			ZWrite Off // don't write to depth buffer 
			Blend SrcAlpha One // additive blending to add colors

			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			
			struct vertexInput
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};
			
			struct vertexOutput
			{
				float2 uvLeft : TEXCOORD0;
				float4 vertex : SV_POSITION;
			};
			
			sampler2D _LeftTex;
			uniform float4 _LeftTex_ST;

			vertexOutput vert(vertexInput i)
			{
				vertexOutput o;
				o.vertex = UnityObjectToClipPos(i.vertex);
				o.uvLeft = TRANSFORM_TEX(i.uv, _LeftTex);
				return o;
			}
			
			float4 frag(vertexOutput i) : SV_Target
			{
				float3 opacityConfig = lerp(tex2D(_LeftTex, i.uvLeft),
					tex2D(_LeftTex, i.uvLeft),
					unity_StereoEyeIndex);
				return float4(opacityConfig.x, opacityConfig.y, opacityConfig.z, 0.6);
			}
			ENDCG
		}
	}
		FallBack "Diffuse"
}