using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlacksmithTeleport : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    void OnMouseDown()
    {
        // this object was clicked - do something
        SceneManager.LoadScene("blacksmith");
    }
    //void Update()
    // {
    //  if (Input.GetMouseButton(0))
    //     SceneManager.LoadScene("blacksmith");

    //}
}
