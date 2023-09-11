using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class ControlMusica : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

   public void ControldeMusica (float sliderMusica)
   {
    audioMixer.SetFloat("VolumenMusica", Mathf.Log10(sliderMusica) * 20); 
   }

    public void volverAlInicio()
    {
        SceneManager.LoadScene(1);
    }

    
}
