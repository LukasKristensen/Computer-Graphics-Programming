using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shaderScript1 : MonoBehaviour
{
    public int shaderInputConfig = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Renderer>().sharedMaterial.SetFloat("inputShader", shaderInputConfig);
    }
}
