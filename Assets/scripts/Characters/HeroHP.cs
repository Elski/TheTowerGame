using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroHP : MonoBehaviour {
   
    public Text hp;
  
    // Update is called once per frame
    void Update() {
        
        //Hp is shown as a value in prepared UI   
        hp.text = (Hero.curHp*100).ToString("N2");
    }
}

