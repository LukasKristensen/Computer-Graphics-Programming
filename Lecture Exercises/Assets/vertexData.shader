Shader "Cg shader with all built-in vertex input parameters" {
    SubShader{
       Pass {
          CGPROGRAM
          #pragma vertex vert  
          #pragma fragment frag 
          float inputShader = 0;

          struct vertexInput {
             float4 vertex : POSITION;
             float4 tangent : TANGENT;
             float3 normal : NORMAL;
             float4 texcoord : TEXCOORD0;
             float4 texcoord1 : TEXCOORD1;
             float4 texcoord2 : TEXCOORD2;
             float4 texcoord3 : TEXCOORD3;
             fixed4 color : COLOR;
          };
          struct vertexOutput {
             float4 pos : SV_POSITION;
             float4 col : TEXCOORD0;
          };

          vertexOutput vert(vertexInput input)
          {
             vertexOutput output;

             output.pos = UnityObjectToClipPos(input.vertex);
             output.col = input.texcoord; // set the output color

             // other possibilities to play with:
             if (inputShader == 0) {
                 output.col = input.vertex;
             }
             if (inputShader == 1){
                output.col = input.tangent;
             }
             if (inputShader == 2) {
                 output.col = input.texcoord;
             }
             if (inputShader == 3) {
                 output.col = input.texcoord1;
             }
             if (inputShader == 4) {
                 output.col = input.texcoord2;
             }
             if (inputShader == 5) {
                 output.col = input.texcoord3;
             }
             if (inputShader == 6) {
                output.col = input.color;
                }

             return output;
          }

          float4 frag(vertexOutput input) : COLOR
          {
             return input.col;
          }

          ENDCG
       }
    }
}