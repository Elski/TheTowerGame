using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Klasa odpowiedzialna za pokazanie hp bohatera
/// </summary>
public class HeroHP : MonoBehaviour {
   
    public Text hp;
  
   
    void Update() {
        
          
        hp.text = (Hero.curHp*100).ToString("N2");
    }
}

