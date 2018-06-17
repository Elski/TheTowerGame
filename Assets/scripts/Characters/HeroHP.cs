using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroHP : MonoBehaviour {
   
    public Text hp;
    // Use this for initialization
    void Start() {
     
    }

    // Update is called once per frame
    void Update() {
        
             
        hp.text = (Hero.curHp*100).ToString("N2");
        //transform.localScale += new Vector3(change,0,0);
        //  change = 0;

    }
}

