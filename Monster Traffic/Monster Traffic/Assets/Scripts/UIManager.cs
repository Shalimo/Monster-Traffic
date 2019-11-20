using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button[] buttons;  
    public Button pause;
    public Text scoreText;
    public Text gameOverText;
    public Text currentScore;
    private int score;
    private bool gameOver;

    void Start()
    {
        score = 0;
        InvokeRepeating("ScoreUpdate", 0f, 0.5f);
    }

    void Update()
    {
        scoreText.text = "Score: " + score;
        currentScore.text = "Your score: " + score;
    }

    void ScoreUpdate()
    {
        if (!gameOver)
        {
            score++;
        }
    }

    public void GameOverActivated()
    {
        gameOver = true;
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }
        gameOverText.gameObject.SetActive(true);
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
