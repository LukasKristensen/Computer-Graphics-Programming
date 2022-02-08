using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigiFollow : MonoBehaviour
{
    public GameObject followed;



    void Update()
    {
        GetComponent<Rigidbody>().velocity = 0.95f * GetComponent<Rigidbody>().velocity + 0.05f * (followed.transform.position - transform.position);
    }
}
