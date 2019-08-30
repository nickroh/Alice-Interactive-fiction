using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChange : MonoBehaviour
{
    public void ToMain()
    {
    	SceneManager.LoadScene("Main");
    }

    public void ToStage1_1()
    {
    	SceneManager.LoadScene("Stage_1.1");
    }

    public void ToStage1_2()
    {
       	SceneManager.LoadScene("Stage_1");	
    }
    public void ToStage1_3()
    {
    	
    }
    public void ToStage1_4()
    {
    	
    }
    public void ToStage1_5()
    {
    	
    }
    public void ToStage1_6()
    {
    	
    }
    public void ToStage1_7()
    {
    	
    }
    public void ToStage1_8()
    {
    	
    }
    public void ToStage1_9()
    {
    	
    }
    public void ToLevelSelect()
    {
    	SceneManager.LoadScene("Stage");
    }

    public void ToLevel1()
    {
    	SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
    	Application.Quit();
    }
}
