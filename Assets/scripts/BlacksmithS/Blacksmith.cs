using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


//klasa odpowiedzialna za dodawanie punktow,ich wyswietlanie oraz odswiezanie obrazu
public class Blacksmith : MonoBehaviour
{

    public static Blacksmith manager;
    public Text swordtext;
    public Text armortext;

    void Start()
    {
        manager = this;
        UpdateUI();

    }
    public void UpdateUI()
    {
        swordtext.text = (Hero.swordPower).ToString("N2");
        armortext.text = (Hero.armorPower).ToString("N2");
        
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
        }
    }

    public void Leave()
    {
        // this object was clicked - do something
        SceneManager.LoadScene("outside");
    }

}