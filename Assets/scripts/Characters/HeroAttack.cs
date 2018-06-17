using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroAttack : MonoBehaviour {


    public void Start()
    {
        StartCoroutine(waiter());
    }

        IEnumerator waiter()
        {
            //Move towards enemy
            transform.position += new Vector3(10.0f * Time.fixedDeltaTime, 0, 0.0f);
            //Wait
            yield return new WaitForSeconds(1);
            //Return to position
            transform.position += new Vector3(-10.0f * Time.fixedDeltaTime, 0, 0.0f);
        } 
}
