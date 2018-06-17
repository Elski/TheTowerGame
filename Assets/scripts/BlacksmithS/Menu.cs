using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



/// <summary>
/// Klasa odpowiedzialna za zmiane sceny
/// </summary>
public class Menu : MonoBehaviour
{

    public void Enter()
    {
        //Change scene to "outside"
        SceneManager.LoadScene("outside");
    }

    public void Leave()
    {
        //Quit aplication
        Application.Quit();
    }

}