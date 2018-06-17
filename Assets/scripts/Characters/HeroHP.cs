using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroHP : MonoBehaviour {
    private float maxHP = Hero.curHp;
    private float previousHp=Hero.curHp;
    float change;
    float left;
    // Use this for initialization
    void Start() {
        change = 0;
        maxHP = Hero.curHp;
        previousHp = Hero.curHp;
        left =maxHP;
    }

    // Update is called once per frame
    void Update() {

        if (previousHp != Hero.curHp)
        {
            change = -(Hero.curHp / maxHP);
            previousHp = Hero.curHp;


            if (change > 1)
            {
                change = left;
            }
            left = left - change;
        }
      

        transform.localScale += new Vector3(change,0,0);
        change = 0;
	}
}
