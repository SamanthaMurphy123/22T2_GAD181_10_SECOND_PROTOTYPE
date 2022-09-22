using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public GameOverScreen gameOver;

    public float timeLeft = 10f;
    public TMPro.TextMeshProUGUI startText; // used for showing countdown from 3, 2, 1 
    public int seconds;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        startText.text = (timeLeft).ToString("0");

        
        if (timeLeft <= 0)
        {
            //Do something useful or Load a new game scene depending on your use-case

            gameOver.Setup();
            Time.timeScale = 0f;

        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            timeLeft = 10f;
        }
    }
}


    