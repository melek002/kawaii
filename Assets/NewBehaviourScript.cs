using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{ public void call(int a, int b)
    { 
        int c = a + b;
        int e = a - b;
        int f = a % b;
        
        Debug.Log(c);
        Debug.Log(e);
        Debug.Log(f);



    }

    // Start is called before the first frame update
    void Start()
    {
        call(17, 10);
        call(10, 5);
    }

    // Update is called once per frame
    void Update()
    {

    }
  
   
}
