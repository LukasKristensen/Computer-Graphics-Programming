using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lecture5_QuaternionFromEuler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float xAngle, yAngle, zAngle;
    void Update()
    {
        transform.localRotation = Quaternion.Euler(0, 30, 0);
    }
}
