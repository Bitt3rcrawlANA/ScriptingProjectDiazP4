using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisExample : MonoBehaviour
{
    public float range;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float xPos = x * range;

        transform.position = new Vector3(xPos, 2f, 0);
        Debug.Log("Value Returned" + x.ToString("F2"));
    }
}
