using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seis : MonoBehaviour
{
    public int Day;

    // Start is called before the first frame update
    void Start()
    {
        if (Day <= 5)
        {
            Debug.Log($"{Day} don't belong to the weekend");
        }
        else if(Day > 5)
        {
            Debug.Log($"{Day} belong to the weekend");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
