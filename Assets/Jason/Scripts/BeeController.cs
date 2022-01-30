using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BeeController : MonoBehaviour
{

    private Rigidbody2D rb2D;
    public float force = 100;
    public TextMeshProUGUI winLose;

    void Start()
    {
        winLose.enabled = false;
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.isKinematic = true;
    }

    public void StartBee()
    {
        rb2D.isKinematic = false;
        rb2D.AddForce(transform.right * force);
    }

    private void SlowBee()
    {
        Debug.Log("SlowBee");
        rb2D.velocity = rb2D.velocity * 0.8f;
    }

    private void FastBee()
    {
        Debug.Log("FastBee");
        rb2D.velocity = rb2D.velocity * 1.2f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Bee Trigger Tag = " + collision.tag);
        if (collision.tag == "Smoke")
        {
            SlowBee();
        }

        if(collision.tag == "Fan")
        {
            FastBee();
        }

        if(collision.tag == "Hive")
        {
            Debug.Log("You win!");
            winLose.enabled = true;
            winLose.text = "You Win";
            rb2D.velocity = rb2D.velocity - rb2D.velocity;
        }

        if(collision.tag == "Frog")
        {
            winLose.enabled = true;
            winLose.text = "You Lose";
            rb2D.velocity = rb2D.velocity - rb2D.velocity;
        }
    }
}
