using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void ToMain()
    {
    	SceneManager.LoadScene("Main");
    }

    public void To_chp_1_1()
    {
    	SceneManager.LoadScene("chp_1.1");
    }

    public void To_chp_1_2()
    {
    	SceneManager.LoadScene("chp_1.2");
    }

    public void To_chp_1_3()
    {
    	SceneManager.LoadScene("chp_1.3");
    }
    public void To_chp_1_4()
    {
    	SceneManager.LoadScene("chp_1.4");
    }
    public void To_chp_1_5()
    {
    	SceneManager.LoadScene("chp_1.5");
    }
    
    public void QuitGame()
    {
    	Application.Quit();
    }
}
