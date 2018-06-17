using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartTower : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    void OnMouseDown()
    {
        // this object was clicked - do something
        SceneManager.LoadScene("inside");
    }
    // Update is called once per frame
    void Update () {
       if (Input.GetMouseButton(0)) { }
           
        
    }
}
