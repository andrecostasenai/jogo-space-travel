using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Score.score > 0 && Score.score % 5 == 0)        
            speed += 0.001f;        

        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
