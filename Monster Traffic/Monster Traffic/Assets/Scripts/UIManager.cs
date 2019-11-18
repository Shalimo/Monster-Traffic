using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button[] buttons;
    public Text scoreText;
    public Button pause;
    public Text GameOverText;
    public Text currentScore;
    int score;
    bool gameOver;

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
        currentScore.text = "Your score: " + score;



    }

    void scoreUpdate()
    {
        if (!gameOver)
        {
            score++;
        }
    }

    public void gameOverActivated()
    {
        gameOver = true;

        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }
        GameOverText.gameObject.SetActive(true);
        currentScore.gameObject.SetActive(true);

        scoreText.gameObject.SetActive(false);
        pause.gameObject.SetActive(false);
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

    public void Play()
    {
        Time.timeScale = 1;
        Application.LoadLevel("SampleScene");
        
    }

    public void Menu()
    {
        Application.LoadLevel("Menu");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
