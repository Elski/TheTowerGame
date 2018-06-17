using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


//klasa odpowiedzialna za dodawanie punktow,ich wyswietlanie oraz odswiezanie obrazu
public class Manager : MonoBehaviour {

    public static Manager manager;
    public Text endurancetext;
    public Text charismatext;
    public Text strenghttext;
    public Text agilitytext;
    public Text lucktext;
    public Text fencingtext;
    public Text vitalitytext;
    // Use this for initialization

    void Start()
    {
        manager = this;
        UpdateUI();

    }
    // Update is called once per frame
    void Update () {
		
	}

    public void Leave()
    {
        // this object was clicked - do something
        SceneManager.LoadScene("outside");
    }

    public void UpdateUI()
    {
        endurancetext.text = (Hero.endurance).ToString("N2");
        charismatext.text = (Hero.charisma).ToString("N2");
        strenghttext.text = (Hero.strenght).ToString("N2");
        agilitytext.text = (Hero.agility).ToString("N2");
        lucktext.text = (Hero.luck).ToString("N2");
        fencingtext.text = (Hero.fencing).ToString("N2");
        vitalitytext.text = (Hero.vitality).ToString("N2");
    }

    public void Button_ClickE()
    {
        if (Hero.points > 0)
        {
            Hero.endurance = Hero.endurance + 1;
            Hero.points=Hero.points-1;
            UpdateUI();
            print(Hero.points);
        }
        else
        {
            print(Hero.endurance);
        }
    }

    public void Button_ClickC()
    {
        if (Hero.points > 0)
        {
            Hero.charisma = Hero.charisma + 1;
            Hero.points = Hero.points - 1;
            UpdateUI();
            print(Hero.points);
        }
        else
        {
            print(Hero.charisma);
        }
    }
    public void Button_ClickS()
    {
        if (Hero.points > 0)
        {
            Hero.strenght = Hero.strenght + 1;
            Hero.points = Hero.points - 1;
            UpdateUI();
            print(Hero.points);
        }
        else
        {
            print(Hero.strenght);
        }
    }
    public void Button_ClickA()
    {
        if (Hero.points > 0)
        {
            Hero.agility = Hero.agility + 1;
            Hero.points = Hero.points - 1;
            UpdateUI();
            print(Hero.points);
        }
        else
        {
            print(Hero.agility);
        }
    }
    public void Button_ClickL()
    {
        if (Hero.points > 0)
        {
            Hero.luck = Hero.luck + 1;
            Hero.points = Hero.points - 1;
            UpdateUI();
            print(Hero.points);
        }
        else
        {
            print(Hero.luck);
        }
    }
    public void Button_ClickF()
    {
        if (Hero.points > 0)
        {
            Hero.fencing = Hero.fencing + 1;
            Hero.points = Hero.points - 1;
            UpdateUI();
            print(Hero.points);
        }
        else
        {
            print(Hero.fencing);
        }
    }
    public void Button_ClickV()
    {
        if (Hero.points > 0)
        {
            Hero.vitality = Hero.vitality + 1;
            Hero.points = Hero.points - 1;
            UpdateUI();
            print(Hero.points);
        }
        else
        {
            print(Hero.vitality);
        }
    }

}
