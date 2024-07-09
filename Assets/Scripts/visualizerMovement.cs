using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visualizerMovement : MonoBehaviour
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
        Vector3 position = transform.position;
        position.z = (target.position + targetOffset).z;
        transform.position = position;

    }   
      
}
