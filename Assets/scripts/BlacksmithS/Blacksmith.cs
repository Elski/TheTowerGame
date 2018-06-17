using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// Klasa odpowiedzialna za dodawanie punktow,ich wyswietlanie oraz odswiezanie obrazu
/// </summary>

public class Blacksmith : MonoBehaviour
{

    public static Blacksmith manager;
    public Text swordtext;
    public Text armortext;
    public Text goldtext;

    void Start()
    {
        manager = this;
        UpdateUI();

    }
    public void UpdateUI()
    {
        swordtext.text = (Hero.swordPower).ToString("N2");
        armortext.text = (Hero.armorPower).ToString("N2");
        goldtext.text = (Hero.gold).ToString("N2");

    }

    public void Button_Click() { 
            if (Hero.gold > 0)
            {
                Hero.swordPower = Hero.swordPower + 1;
                Hero.gold = Hero.gold - 1;
            UpdateUI();
            print("dodano punkty");
            }
            else
            {
                print(Hero.swordPower);
                print(Hero.gold);
        }
     }

    public void Button_Click2()
    {
        if (Hero.gold > 0)
        {
            Hero.armorPower = Hero.armorPower + 1;
            Hero.gold = Hero.gold - 1;
            UpdateUI();
            print("dodano punkty");
        }
        else
        {
            print(Hero.armorPower);
            print(Hero.gold);
        }
    }

    public void Leave()
    {
        
        SceneManager.LoadScene("outside");
    }

}