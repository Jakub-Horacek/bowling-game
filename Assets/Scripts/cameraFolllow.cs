using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFolllow : MonoBehaviour
{
    public Transform target;
    public Vector3 targetOffset;
    public float smoothTime = 0.3f;
    private Vector3 velocity = Vector3.zero;

    void Start()
    {
        targetOffset = transform.position - target.position;
    }

    void FixedUpdate()
    {
        if (target)
        {
            //transform.position = Vector3.Lerp(transform.position, target.position + targetOffset, 0.1f);
            transform.position = Vector3.SmoothDamp(transform.position, target.position + targetOffset, ref velocity, smoothTime);
        }
    }
}
