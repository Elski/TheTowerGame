using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


//klasa odpowiedzialna za dodawanie punktow,ich wyswietlanie oraz odswiezanie obrazu
public class Menu : MonoBehaviour
{

    public void Enter()
    {
        // this object was clicked - do something
        SceneManager.LoadScene("outside");
    }

    public void Leave()
    {
        // this object was clicked - do something
        Application.Quit();
    }

}