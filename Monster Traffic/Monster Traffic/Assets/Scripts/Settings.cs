using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    public AudioMixer am;

    public void AudioTurnOn(float maxValue = 20f)
    {
        am.SetFloat("masterVolume", maxValue);
    }

    public void AudioTurnOff(float minValue = -80f)
    {
        am.SetFloat("masterVolume", minValue);
    }
}
