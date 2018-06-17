using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Klasa odpowiedzialna za ruch bohatera
/// </summary>
public class HeroAttack : MonoBehaviour {


    public void Start()
    {
        StartCoroutine(waiter());
    }

        IEnumerator waiter()
        {
            
            transform.position += new Vector3(10.0f * Time.fixedDeltaTime, 0, 0.0f);
            
            yield return new WaitForSeconds(1);
            
            transform.position += new Vector3(-10.0f * Time.fixedDeltaTime, 0, 0.0f);
        } 
}
