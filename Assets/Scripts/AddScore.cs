using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("tiro"))
        {
            Score.score++;
            if (Score.score % 5 == 0)
                Arma.tiros += 5;
        }        
    }
}
