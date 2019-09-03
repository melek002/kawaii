using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed = 10.0f;
    float  hitfactor(Vector2 Ballposition,Vector2 Racketposition,float Racketheight )
    {
        return (Ballposition.x - Racketposition.x) / Racketheight;
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
         if(collision.gameObject.name == "racket")
        {
            float x = hitfactor(transform.position, collision.transform.position, collision.collider.bounds.size.x);
            Vector2 d = new Vector2(x, 1).normalized;
            GetComponent<Rigidbody>().velocity = d* speed;
            Debug.Log("racket");
        }
    }




    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
