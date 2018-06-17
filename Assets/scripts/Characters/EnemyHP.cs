using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{

    private float maxHP;
    private float previousHp;
    float change;
    float left;
    private Enemy obelisk;
    // Use this for initialization
    void Start()
    {
        GameObject thePlayer = GameObject.Find("Enemy");
        Enemy obelisk = thePlayer.GetComponent<Enemy>();
        change = 0;
        maxHP = obelisk.curHp;
        previousHp = obelisk.curHp;
        left = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject thePlayer = GameObject.Find("Enemy");
        Enemy obelisk = thePlayer.GetComponent<Enemy>();
        if (previousHp != obelisk.curHp)
        {
            change = -(obelisk.curHp / maxHP);
            previousHp = obelisk.curHp;


            if (change > 1)
            {
                change = left;
            }
            left = left - change;
        }


        transform.localScale += new Vector3(change, 0, 0);
        change = 0;
    }
}
