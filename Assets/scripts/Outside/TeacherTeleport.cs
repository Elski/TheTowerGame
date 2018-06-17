using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
/// <summary>
/// Klasa odpowiada za przejscie miedzy scenami
/// </summary>
public class TeacherTeleport : MonoBehaviour
{

    void OnMouseDown()
    {
        
        SceneManager.LoadScene("teacher");
    }
   
}