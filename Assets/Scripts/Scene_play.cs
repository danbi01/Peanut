using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_play : MonoBehaviour
{
    public static void BackButtonClickHandler(){
        SceneManager.LoadScene("Main");
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
