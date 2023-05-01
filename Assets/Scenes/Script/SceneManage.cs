using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    // Update is called once per frame
    public void LoadScene()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}