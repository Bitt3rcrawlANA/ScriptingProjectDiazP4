using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataType : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //Value
        Vector3 currentPos = transform.position;
        currentPos = new Vector3(0, 2, 0);

        //Reference
        Transform tran = transform;
        tran.position = new Vector3(0, 2, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
