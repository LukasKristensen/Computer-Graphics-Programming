Shader "Cg shader for RGB cube" {
    SubShader{
       Pass {
          CGPROGRAM

          #pragma vertex vert // vert function is the vertex shader 
          #pragma fragment frag // frag function is the fragment shader

          // for multiple vertex output parameters an output structure 
          // is defined:
          struct vertexOutput {
             float4 pos : SV_POSITION;
             float4 col : TEXCOORD0;
          };

          vertexOutput vert(float4 vertexPos : POSITION)
              // vertex shader 
           {
            vertexOutput output; // we don't need to type 'struct' here
            output.pos = UnityObjectToClipPos(vertexPos);
            float r = vertexPos.x + 0.5;
            float g = vertexPos.y + 0.5;
            float b = vertexPos.z + 0.5;


            output.col = float4(1.0-r,1.0-g,1.0-b, 0.5);
            // Here the vertex shader writes output data
            // to the output structure. We add 0.5 to the 
            // x, y, and z coordinates, because the 
            // coordinates of the cube are between -0.5 and
            // 0.5 but we need them between 0.0 and 1.0. 
           return output;
        }

        float4 frag(vertexOutput input) : COLOR // fragment shader
        {
           return input.col;
        // Here the fragment shader returns the "col" input 
        // parameter with semantic TEXCOORD0 as nameless
        // output parameter with semantic COLOR.
  }

  ENDCG
}
    }
}