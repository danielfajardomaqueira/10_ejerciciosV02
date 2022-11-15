using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tres : MonoBehaviour
{

    public int Age;
    public string Name;

    // Start is called before the first frame update
    void Start()
    {
        //With this line, i can show the name of the user and her/his age.
        Debug.Log($"Hello, {Name}! You are {Age} years old");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
