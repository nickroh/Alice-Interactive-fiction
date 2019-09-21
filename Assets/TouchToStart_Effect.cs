using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchToStart_Effect : MonoBehaviour
{
   
    public Text txt;
	
	private float alpha = 0.0f;
	private bool status;
   
    void Start()
    {
        txt = GetComponent<Text> ();
		txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, alpha);
		status = true;

    	StartCoroutine ("PlayText");
    }

    IEnumerator PlayText()
    {	
    	while(true)
		{
			if(status == true)
			{
				alpha += 0.01f;
				txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, alpha);
				if(alpha >= 1.0f)
				{
					status = false;
				}
				yield return new WaitForSeconds (0.01f);
			}

			if(status == false)
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

