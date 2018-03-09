Shader "Custom/Rim" {
	Properties {
		_RimPower("Rim Power", Range(0,10)) = 1
		_RimColor("Color", Color) = (1,0,0,1)
		_MainTex("Albedo", 2D) = "White" {} 
	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		LOD 200

		CGPROGRAM
		// Physically based Standard lighting model, and enable shadows on all light types
		#pragma surface surf Lambert

		// Use shader model 3.0 target, to get nicer looking lighting
		#pragma target 3.0

		sampler2D _MainTex;
		half _RimPower;
		fixed4 _RimColor;

		struct Input {
			half2 uv_MainText : TEXCOORD0;
			float3 viewDir;
			float3 worldNormal;
		};

		void surf (Input IN, inout SurfaceOutput o) {
			o.Albedo = tex2D(_MainTex, IN.uv_MainText).rgb;
			o.Emission = pow(1.0 - dot(IN.worldNormal, IN.viewDir), _RimPower)*_RimColor.rgb; 
		}
		ENDCG
	}
	FallBack "Diffuse"
}
