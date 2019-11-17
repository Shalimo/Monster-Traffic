using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitPressed()
    {
        Application.Quit();
    }






}
