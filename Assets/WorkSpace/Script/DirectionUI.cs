using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionUI : MonoBehaviour
{
    public GameObject MainCamera;

    public void ResetDirection()
    {
        MainCamera.transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    private void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, -MainCamera.transform.eulerAngles.y - 90);
    }
}
