﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroAttack : MonoBehaviour {


    public void Start()
    {
        StartCoroutine(waiter());
    }


    // Update is called once per frame
    
    
        IEnumerator waiter()
        {

            transform.position += new Vector3(10.0f * Time.fixedDeltaTime, 0, 0.0f);
            yield return new WaitForSeconds(1);
            transform.position += new Vector3(-10.0f * Time.fixedDeltaTime, 0, 0.0f);
           


        }

    
}
