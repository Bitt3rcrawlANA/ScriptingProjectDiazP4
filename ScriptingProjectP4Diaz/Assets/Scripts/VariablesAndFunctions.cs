using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
// Create a variable of type int
    int MyInt = 39;
   // Start is called before the first frame update
    void Start()
    {
        MyInt = MultiplyByTwo(MyInt);
        Debug.Log(MyInt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
