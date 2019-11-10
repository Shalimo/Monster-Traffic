using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Text scoreText;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        InvokeRepeating("scoreUpdate", 1.0f, 0.5f);
        
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
}
