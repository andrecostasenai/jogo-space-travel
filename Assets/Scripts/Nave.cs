using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    public GameManager gameManager;

    public float velocity = 1;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = Vector2.up * velocity;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = Vector2.down * velocity;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = Vector2.left * velocity;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = Vector2.right * (velocity - 1);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
