using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


/// <summary>
/// Klasa odpowiedzialna za wyswietlanie odpowiedniego pietra
/// </summary>
public class Floor : MonoBehaviour
{


    public Text floortext;
 

    void Start()
    {
        UpdateUI();

    }
    

    public void UpdateUI()
    {   
        int nr = Hero.floor;
        floortext.text = (nr).ToString("N2");   
    }

}
