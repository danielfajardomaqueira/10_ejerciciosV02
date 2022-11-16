using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nueve : MonoBehaviour
{

    public int NumCandy;
    public int NumPeople;
    private int result1;
    private int result2;

    // Start is called before the first frame update
    void Start()
    {
        result1 = NumCandy % NumPeople;
        result2 = NumCandy / NumPeople;
        Debug.Log(string.Format("Each person takes {0}, and {1} are left", result2, result1));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
