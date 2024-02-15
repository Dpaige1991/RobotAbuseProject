using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotCameraMovement : MonoBehaviour
{
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(target.position, Vector3.up, 50 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(target.position, -Vector3.up, 50 * Time.deltaTime);
        }
    }
}
