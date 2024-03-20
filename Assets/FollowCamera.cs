using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject followObject;
    // Camera should be the same as the car's position
    void LateUpdate()
    {
        transform.position = followObject.transform.position + new UnityEngine.Vector3(0,0, -10);
    }
}
