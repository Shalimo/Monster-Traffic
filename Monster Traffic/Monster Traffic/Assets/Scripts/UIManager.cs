using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Text scoreText;
    public Button pause;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        //через 0 секунд каждые 0.5 секунд
        InvokeRepeating("scoreUpdate", 0f, 0.5f);
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        
        
        
    }

    void scoreUpdate()
    {
        score++;
    }

    public void Pause()
    {
        if (Time.timeScale == 1)
        {

            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }
}
