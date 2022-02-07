using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeScript : MonoBehaviour
{
    Color localMaterial;
    public bool startFade;
    public float fadeDuration;
    float fadeTimeStart = 0.0f;
    float fade = 0.0f;

    void Start()
    {
        localMaterial = GetComponent<MeshRenderer>().material.color;

    }

    void Update()
    {
        if(localMaterial.a > 0.0f && startFade) {
            if (fadeTimeStart == 0.0f)
            {
                fadeTimeStart = UnityEngine.Time.time;
            }
            else{
                fade = (UnityEngine.Time.time-fadeTimeStart)/fadeDuration;
                localMaterial.a = 1-fade;
            }
            GetComponent<MeshRenderer>().material.color = localMaterial;
        }
        else if (startFade)
        {
            Destroy(gameObject);
        }



    }
}
