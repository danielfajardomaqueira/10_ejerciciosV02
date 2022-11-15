using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dos : MonoBehaviour
{

    public string Name;
    public string City;
    // Start is called before the first frame update
    void Start()
    {
        //With this line, i can say the name of the user and the name of the city in the same phrase.
        Debug.Log($"Hello, {Name}! Welcome to {City}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
