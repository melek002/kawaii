using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   public  Transform birdtransform;
    Vector3 range;

     void Awake()
    {
      range =  transform.position - birdtransform.position;
    }
     void FixedUpdate()
    {
        transform.position = new Vector3(range.x + birdtransform.position.x, transform.position.y, range.z + birdtransform.position.z);
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
