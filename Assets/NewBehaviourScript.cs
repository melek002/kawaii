using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{ public void add(int a, int b)
    { 
        int c = a + b; 
        Debug.Log(c);
       



    }
    public void mult(int a, int b)
    {
        int e = a * b;
        if (  e < 0)
        { Debug.Log("e is negative "); }
        else if (e > 0)
        { Debug.Log("e is postive"); }
        else
        { Debug.Log(" e is null"); }


    }
    public void subt(int a, int b)
    {
       
        int f = a - b;
        Debug.Log(f);

    }
    
    // Start is called before the first frame update
    void Start()
    {
        subt(17, 10);
        add(10, 5);
        mult(30, 0);
        
    }


    // Update is called once per frame
    void Update()
    {

    }
  
   
}
