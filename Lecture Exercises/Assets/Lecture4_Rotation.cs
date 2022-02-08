using UnityEngine;
[ExecuteInEditMode]
public class Lecture4_Rotation : MonoBehaviour
{
    public float bankZ, elevationX, headingY;
    void Update()
    {
        transform.localEulerAngles =
           new Vector3(elevationX, headingY, bankZ);
    }
}