using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;

    private void Start()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (gameOverCanvas.activeSelf)        
            if (Input.GetKey(KeyCode.Space))            
                Play();        
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        GameObject.Find("txtGameOver").SetActive(true);
        Time.timeScale = 0;
    }

    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
