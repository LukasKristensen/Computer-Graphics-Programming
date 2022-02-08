using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lecture5_CalibratedTracking : MonoBehaviour
{
    public GameObject calibrationPose;
    public GameObject trackerWhenCalibrating, currentTracker;

    // Update is called once per frame
    void Update()
    {
        transform.rotation = currentTracker.transform.rotation * Quaternion.Inverse(trackerWhenCalibrating.transform.rotation) * calibrationPose.transform.rotation;
        transform.position = currentTracker.transform.position + trackerWhenCalibrating.transform.position - calibrationPose.transform.position;
    }
}
