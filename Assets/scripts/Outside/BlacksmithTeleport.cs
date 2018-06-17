using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Klasa odpowiedzialna za zmiane sceny
/// </summary>
public class BlacksmithTeleport : MonoBehaviour {

	
	void Start () {
		
	}
    void OnMouseDown()
    {
        
        SceneManager.LoadScene("blacksmith");
    }
  
}
