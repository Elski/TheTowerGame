using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

    public void Move()
    {
        StartCoroutine(waiter());
    }


    // Update is called once per frame


    IEnumerator waiter()
    {
        //Wait for player action
        yield return new WaitForSeconds(1);
        //Move towards player
        transform.position += new Vector3(-10.0f * Time.fixedDeltaTime, 0, 0.0f);
        //Wait
        yield return new WaitForSeconds(1);
        //Return to position
        transform.position += new Vector3(10.0f * Time.fixedDeltaTime, 0, 0.0f);



    }
}
