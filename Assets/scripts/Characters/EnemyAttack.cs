using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Klasa odpowiedzialna za ruch przeciwnika
/// </summary>
public class EnemyAttack : MonoBehaviour {

    public void Move()
    {
        StartCoroutine(waiter());
    }


    


    IEnumerator waiter()
    {
        
        yield return new WaitForSeconds(1);
        
        transform.position += new Vector3(-10.0f * Time.fixedDeltaTime, 0, 0.0f);
        
        yield return new WaitForSeconds(1);
        
        transform.position += new Vector3(10.0f * Time.fixedDeltaTime, 0, 0.0f);



    }
}
