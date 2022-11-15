using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class siete : MonoBehaviour
{
    public string Letter;

    // Start is called before the first frame update
    void Start()
    {
        if (Letter == "a" || Letter == "e" || Letter == "i" || Letter == "e" || Letter == "u")
        {
            Debug.Log($"{Letter} es vocal");
        }
        else
        {
            Debug.Log($"{Letter} es consonante");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
