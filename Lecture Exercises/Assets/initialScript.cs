using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initialScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float t = 0.0f, velocity = 0.0f;
    public Vector3 first, second, third;
    public GameObject P0, P1, P2;

    void Update()
    {
        /// LINEAR
        /*t += velocity * Time.deltaTime;
        if (t > 1.0) { t = 1.0f; }
        if (t < 0.0) { t = 0.0f; }
        transform.position = (1 - t) * first + t * second; */


        /// SINE
        /*if (transform.position == second){ velocity *= -1; }
        if (transform.position == first) { velocity *= -1; }


        t = Mathf.Sin(Time.time);
        if (t < 0) { t *= -1; }

        transform.position = (1 - t) * first + t * second;*/

        /// QUADRATIC BEZIER
        /*t = Mathf.Sin(Time.time);
        if (t < 0) { t *= -1; }
        transform.position = (1.0f - t) * (1.0f - t) * first + 2 * (1.0f - t) * t * second + t * t * third; */

          /// BETWEEN OBJECTS
        t = Mathf.Sin(Time.time);
        if (t < 0) { t *= -1; }
        transform.position = (1.0f - t) * (1.0f - t) * P0.transform.position + 2 * (1.0f - t) * t * P1.transform.position + t * t * P2.transform.position;

    }

}
