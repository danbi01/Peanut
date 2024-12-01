using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_main : MonoBehaviour
{
    public void StartButtonClickHandler(){
        SceneManager.LoadScene("Play");
    }
    public void SettingButtonClickHandler(){
        SceneManager.LoadScene("Settings");
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
