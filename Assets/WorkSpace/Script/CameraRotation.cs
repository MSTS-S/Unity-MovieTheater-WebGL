using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    const float ROTATION_SPEED = 0.85f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(-ROTATION_SPEED, -ROTATION_SPEED, 0.0f);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(ROTATION_SPEED, -ROTATION_SPEED, 0.0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(-ROTATION_SPEED, ROTATION_SPEED, 0.0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(ROTATION_SPEED, ROTATION_SPEED, 0.0f);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0.0f, -ROTATION_SPEED, 0.0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0.0f, ROTATION_SPEED, 0.0f);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(-ROTATION_SPEED, 0.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(ROTATION_SPEED, 0.0f, 0.0f);
        }
    }
}
