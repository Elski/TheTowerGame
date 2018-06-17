using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Klasa odpowiedzialna za dzialanie jednego ze skilli
/// </summary>
public class BigAttackController : MonoBehaviour
{

    public GameObject yourButton;

    public static BigAttackController singleton = null;

    void Awake()
    {
        
        if (singleton == null)
        {
            
            singleton = this;
           
        }

        
        else if (singleton != this)
        {
            
            Destroy(gameObject);
        }
    }
}