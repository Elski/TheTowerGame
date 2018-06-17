using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Klasa odpowiedzialna za dzialanie jednego ze skilli
/// </summary>
public class AddStrScript : MonoBehaviour {

    public GameObject yourButton;

    public static AddStrScript singleton = null;

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
