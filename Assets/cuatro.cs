using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuatro : MonoBehaviour
{

    public int A�oDeNacimiento;
    public int A�oActual;
    public int Age;

    // Start is called before the first frame update
    void Start()
    {
        //In this way, the phrase can show the written value from the user.
        Debug.Log($"if we are in the year {A�oActual} and you were born in {A�oDeNacimiento}, you are {Age} years old");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
