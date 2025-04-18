using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisRawExample : MonoBehaviour
{
    public float range;


    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float xPos = x * range;

        transform.position = new Vector3(xPos, 2f, 0);
        Debug.Log("Value Returned: " + x.ToString("F2"));
    }
}
