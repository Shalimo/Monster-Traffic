using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{

    public void PlayPressed()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
        
    }

    public void ExitPressed()
    {
        Application.Quit();
    }






}
