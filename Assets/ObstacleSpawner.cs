using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float MaxY;
    public float MinY;
    public float distance;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            float obstacleY = Random.Range(MinY, MaxY);
            Vector3 spawnpoistion = new Vector3(transform.position.x + distance, obstacleY, 0);
            collision.gameObject.transform.position = spawnpoistion;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
