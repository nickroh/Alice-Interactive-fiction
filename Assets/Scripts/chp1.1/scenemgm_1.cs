using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemgm_1 : MonoBehaviour
{
    // Start is called before the first frame update
    
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
    public void ToLevelSelect()
    {
    	SceneManager.LoadScene("Stage");
    }

    public void ToLevel1()
    {
    	SceneManager.LoadScene("Game");
    }
}
