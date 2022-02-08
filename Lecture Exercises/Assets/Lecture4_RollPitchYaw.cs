using UnityEngine;
[ExecuteInEditMode]
public class Lecture4_RollPitchYaw : MonoBehaviour
{
    public float degreesPerSecond; // angular speed
    public Vector3 axis;
    void Update()
    {
        transform.Rotate(axis, degreesPerSecond * Time.deltaTime,
        Space.Self);
    }
}
