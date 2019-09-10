using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bird : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float speed = 5.0f;
    public float delay = 2.0f;
    public float flapForce = 100f;
    public bool isdead;
    int score = 0;
    public GameObject ReplayButton;

    
        private void OnCollisionEnter2D(Collision2D collision)
    {
        isdead = true;
        rb2d.velocity = Vector2.zero;
        ReplayButton.SetActive(true);
        GetComponent<Animator>().SetBool("isdead", true);


    }
    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
    public void UnFreeze()
    {
        Time.timeScale = 1;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Score")
        {
            score++;

            Debug.Log(score);
        }
    }
    void Start()
    {
        Time.timeScale = 0;
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.right * speed * Time.deltaTime;

        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isdead)
        {
            rb2d.velocity = Vector2.right * speed * Time.deltaTime;
            rb2d.AddForce(Vector2.up * flapForce);

        }
      
       
    }
}
