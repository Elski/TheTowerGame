using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    //private float maxHP = Enemy.curHp;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float change = 0;
       // change = (Enemy.curHp / maxHP) * 100;
        transform.localScale -= new Vector3(change, 0, 0);
    }
}
