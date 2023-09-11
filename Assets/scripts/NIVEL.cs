using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class NIVEL : MonoBehaviour
{
    public Image Barra;
    AsyncOperation Operacion;

    public void CargarEscena(int Nivel)
    {
         StartCoroutine(Cargando(Nivel));
    }
    IEnumerator Cargando (int Nivel)
    {
        Operacion = SceneManager.LoadSceneAsync(Nivel);
        while(!Operacion.isDone)
        {
            Barra.fillAmount = Operacion.progress;
            yield return null;
        }
    }
    
}
