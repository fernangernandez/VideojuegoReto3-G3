using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MENU : MonoBehaviour
{
    public void Nivel (string Nivel)
    {
        SceneManager.LoadScene(Nivel);
    }
    
    public void Opciones (string Opciones)
    {
        SceneManager.LoadScene(Opciones);
    }

    public void Salir ()
    {
        Application.Quit();
        Debug.Log("SALIR");
    }

    public void Creditos (string Creditos)
    {
        SceneManager.LoadScene(Creditos);
    }
}
