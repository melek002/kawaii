using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
     void OnTriggerExit2D(Collider2D colli)
    {
        if (colli.gameObject.tag == "player")
        {
            transform.position +=  2 * Vector3.right * GetComponent<SpriteRenderer>().bounds.size.x;
        }

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
