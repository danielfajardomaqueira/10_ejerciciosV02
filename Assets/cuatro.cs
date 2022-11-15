using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuatro : MonoBehaviour
{

    public int AñoDeNacimiento;
    public int AñoActual;
    public int Age;

    // Start is called before the first frame update
    void Start()
    {
        //In this way, the phrase can show the written value from the user.
        Debug.Log($"if we are in the year {AñoActual} and you were born in {AñoDeNacimiento}, you are {Age} years old");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
