using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


//klasa odpowiedzialna za dodawanie punktow,ich wyswietlanie oraz odswiezanie obrazu
public class Floor : MonoBehaviour
{


    public Text floortext;
    // Use this for initialization

    void Start()
    {
        UpdateUI();

    }
    // Update is called once per frame
    void Update()
    {

    }


    public void UpdateUI()
    {
        int nr = Hero.floor;
        floortext.text = (nr).ToString("N2");
        
    }

}
