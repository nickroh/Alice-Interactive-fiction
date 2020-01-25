/*
    Scene change
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void ToMain()
    {
    	SceneManager.LoadScene("Menu");
    }

    public void ToGame()
    {
        SceneManager.LoadScene("inkle");
    }
    
    public void QuitGame()
    {
    	Application.Quit();
    }
}
