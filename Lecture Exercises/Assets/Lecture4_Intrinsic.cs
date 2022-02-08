using UnityEngine;
[ExecuteInEditMode]
public class Lecture4_Intrinsic : MonoBehaviour
{
    public float yawY, pitchX, rollZ;
    void Update()
    {
        transform.localEulerAngles = new Vector3(pitchX, yawY, rollZ);
    }
}