﻿using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonManager : MonoBehaviour
{
    //Adding Unity slot to set scene name to be loaded. 
    public string S_LevelOne;
    public string S_LevelTwo;

    //Function for loading levels. 
    public void LoadLevel1()
    {
        //Loads level one. 
        SceneManager.LoadScene(S_LevelOne);
    }
    public void LoadLevel2()
    {
        //Loads level one. 
        SceneManager.LoadScene(S_LevelTwo);
    }
    //Function for quitting game. 
    public void QuitGame()
    {
        //Closes application. 
        Application.Quit();
    }
}