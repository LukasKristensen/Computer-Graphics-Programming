using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lecture5_QuaternionFromAngle : MonoBehaviour
{
    public float angle;
    public Vector3 axis;
    void Update()
    {
        transform.localRotation = Quaternion.AngleAxis(45, Vector3.forward);

    }
}
