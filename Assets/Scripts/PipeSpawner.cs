using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime = 1.5f;
    private float timer = 0;
    public GameObject pipe;
    public float height = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        CriarPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newPipe = CriarPipe();
            Destroy(newPipe, 15);
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    GameObject CriarPipe()
    {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        return newPipe;
    }
}
