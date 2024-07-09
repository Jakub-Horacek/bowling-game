using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    public float ballSpeedForward = 300;
    public float ballSpeedSideways = 500;

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal * ballSpeedSideways, 0.0f, 2 * ballSpeedForward);
        //transform.position += Vector3.forward * Time.deltaTime * ballSpeed;

        GetComponent<Rigidbody>().AddForce(movement * Time.deltaTime);

    }

}
