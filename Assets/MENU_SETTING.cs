using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MENU_SETTING : MonoBehaviour
{
    public AudioMixer MAIN_AUDIO_MIX;
    public void SetFullscreen(bool isfullscreen)
    {
        Screen.fullScreen=isfullscreen;
    }
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
      
    }
    public void SetVolume(float volume)
    {
        MAIN_AUDIO_MIX.SetFloat("volume",volume);
    }
     public void quaylaimenumap()
    {
        SceneManager.LoadScene("MENU_CHINH");
    }
}
