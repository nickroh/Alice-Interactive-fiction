using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems; 

public class Start_Touch : MonoBehaviour
{
	
    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
		{
			if(!EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
			{  
	         	change();
			}
		}

        if(Input.GetMouseButtonDown(0)) 
		{
			if(!EventSystem.current.IsPointerOverGameObject())
			{  
	        	 change();
			}
	
		}
    }

    void change()
    {
    	SceneManager.LoadScene("chp_1.1");
    } 
}
