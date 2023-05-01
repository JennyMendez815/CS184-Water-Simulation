using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHelper : MonoBehaviour
{
    // Update is called once per frame
    void Update() {
         //Cursor.Visable = true;
         if (Input.GetKey(KeyCode.F)) {
            SceneManager.LoadScene("Menu");
         }
    }
}
