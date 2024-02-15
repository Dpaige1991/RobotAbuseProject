using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Attachments : MonoBehaviour
{
    public float x, y, z;
    public GameObject gameObjectToMove;

    public TMP_Text message;
    public bool leftArmAttached;
    public bool rightArmAttached;

    void OnTriggerEnter(Collider collision)
    {
        gameObjectToMove.transform.position = new Vector3(x, y, z);
        if (collision.gameObject.CompareTag("AttachLeft"))
        {
            message.text = "Left Arm Attached";
            leftArmAttached = true;
        }
        else if(collision.gameObject.CompareTag("AttachRight"))
        {
            message.text = "Right Arm Attached";
            rightArmAttached = true;
        }
    }
    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("AttachLeft"))
        {
            message.text = "Left Arm Deattached";
            leftArmAttached = false;
        }
        else if (collision.gameObject.CompareTag("AttachRight"))
        {
            message.text = "Right Arm Deattached";
            rightArmAttached = false;
        }
    }
}
