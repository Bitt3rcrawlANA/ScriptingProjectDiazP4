using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualAxisExample : MonoBehaviour
{
    public float hRange;
    public float yRange;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        float xPos = x * hRange;
        float yPos = y * yRange;

        transform.position = new Vector3(xPos, 0, yPos);
        Debug.Log(x.ToString("F2"));
        Debug.Log(y.ToString("F2"));
    }
}