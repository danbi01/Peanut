using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void StartButtonClickHandler(){
        SceneManager.LoadScene("Play");
    }
    public void SettingButtonClickHandler(){
        SceneManager.LoadScene("Settings");
    }
    public static void BackButtonClickHandler(){
        SceneManager.LoadScene("Main");
    }
}
