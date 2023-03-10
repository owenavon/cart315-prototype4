using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class CameraConstraint : MonoBehaviour
{
    public Transform camTarget;
    public float pLerp = 0.02f;
    public float rLerp = 0.01f;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, camTarget.position, pLerp);
        transform.rotation = Quaternion.Lerp(transform.rotation, camTarget.rotation, rLerp);
    }
}
