using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timercontrol : MonoBehaviour
{
    public GameObject timeIsUp, retryButton;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Countdown.timeLeft <= 0)
        {
            
            Time.timeScale = 0;
            timeIsUp.gameObject.SetActive(true);
            retryButton.gameObject.SetActive(true);
        } 
    }

    public void restartScene()
    {
        timeIsUp.gameObject.SetActive(false);
        retryButton.gameObject.SetActive(false);
        Time.timeScale = 1;
        Countdown.timeLeft = 30f;
        SceneManager.LoadScene("prototype level version 2");
    }
}
