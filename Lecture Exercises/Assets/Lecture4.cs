using UnityEngine;
[ExecuteInEditMode]
public class Lecture4 : MonoBehaviour
{
    public Vector3 row0, row1, row2, row3, column3;
    void Update()
    {
        Matrix4x4 m = transform.localToWorldMatrix;
        row0 = m.GetRow(0);
        row1 = m.GetRow(1);
        row2 = m.GetRow(2);
        row3 = m.GetRow(3);
        column3 = m.GetColumn(3);
    }
}
