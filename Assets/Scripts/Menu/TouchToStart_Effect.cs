/*
	Text Fade in / out loop
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchToStart_Effect : MonoBehaviour
{
   
    public Text txt;
	
	private float alpha = 0.0f; // Initial Opacity
	private bool status; // Increase Opacity or Decrease Opacity True -- Increase False -- Decrease
   
    void Start()
    {
        txt = GetComponent<Text> (); // Get Target Text
		txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, alpha);
		status = true; // Initial status : Increasing

    	StartCoroutine ("PlayText"); // Start Coroutine
    }

    IEnumerator PlayText()
    {	
    	while(true) // Fade in / out Loop
		{
			if(status == true) // Increase
			{
				alpha += 0.01f;
				txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, alpha);
				if(alpha >= 1.0f)
				{
					status = false;
				}
				yield return new WaitForSeconds (0.01f);
			}

			if(status == false) // Decrease
			{
				alpha -= 0.01f;
				txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, alpha);
				if(alpha <= 0.0f)
				{
					status = true;
				}
				yield return new WaitForSeconds (0.01f);
			}
			
		}
    }
  
}

