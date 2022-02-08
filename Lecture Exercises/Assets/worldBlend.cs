using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldBlend : MonoBehaviour
{
    public Vector4 referencePoint;
    public float distanceNear;
    public Color colorNear;
    public Color colorFar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Renderer>().sharedMaterial.SetVector("_Point", referencePoint);
        GetComponent<Renderer>().sharedMaterial.SetFloat("_DistanceNear", distanceNear);
        GetComponent<Renderer>().sharedMaterial.SetColor("_ColorNear", colorNear);
        GetComponent<Renderer>().sharedMaterial.SetColor("_ColorFar", colorFar);
    }
}
