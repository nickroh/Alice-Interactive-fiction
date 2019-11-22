using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems; 

public class Start_Touch : MonoBehaviour
{
	public Color background;
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
		   	 change();
		}
    }

    // IEnumerator FadeOut()
    // {
    // 	while(true)
    // 	{
    // 		GUI.color.a -= 0.1f;
    // 		if(GUI.color.a < 0.2f)
    // 		{
    // 			break;
    // 		}
    // 		yield return new WaitForSeconds(0.01f);
    // 	}
    // }


    void change()
    {
    	SceneManager.LoadScene("chp_1");
    } 
}
