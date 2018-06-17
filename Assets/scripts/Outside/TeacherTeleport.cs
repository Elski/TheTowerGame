using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class TeacherTeleport : MonoBehaviour
{

    void OnMouseDown()
    {
        // this object was clicked - do something
        SceneManager.LoadScene("teacher");
    }
    /*
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    hit.collider.enabled = false;
                    Debug.Log("qqqq");
                }
            }
            else
            {
                Debug.Log("aaaa");
            }
           
        }
        
      
    }*/
}