using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cinco : MonoBehaviour
{
    public int x;
    public int y;

    // Start is called before the first frame update
    void Start()
    {
        if (x < y)
        {
            Debug.Log($"The value of y ({y}), is greater than the value of x ({x})");
        }
        else
        {
            Debug.Log($"The value of x ({x}), is greater than the value of y ({y})");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
