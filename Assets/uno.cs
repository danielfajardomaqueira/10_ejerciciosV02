using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uno : MonoBehaviour
{
    public float Num1;
    public float Num2;
    public float Num3;

    

    // Start is called before the first frame update
    void Start()
    {
        // I just want do the sum of my 3 values.
        Debug.Log($"The value of the sum is {Num1 + Num2 + Num3}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
