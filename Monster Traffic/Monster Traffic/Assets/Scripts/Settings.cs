using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public Slider slider;

    void Update()
    {
        AudioListener.volume = slider.value;
    }
}
