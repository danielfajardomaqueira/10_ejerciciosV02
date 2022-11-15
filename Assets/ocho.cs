using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ocho : MonoBehaviour
{
    public string Month;

    // Start is called before the first frame update
    void Start()
    {
        if (Month == "january" || Month == "march" || Month == "may" || Month == "july" || Month == "august" || Month == "october" || Month == "december")
        {
            Debug.Log($"The Month {Month} has 31 days");
        }
        if (Month == "april" || Month == "june" || Month == "september" || Month == "november")
        {
            Debug.Log($"The Month {Month} has 30 days");
        }
        if (Month == "february")
        {
            Debug.Log($"The Month {Month} has 28 days");
        }
        else
        {
            Debug.Log($"{Month} isn't a month, fool");
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
