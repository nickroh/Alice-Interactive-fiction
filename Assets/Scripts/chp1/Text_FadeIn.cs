using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
	chp1 Fade in/out effect
*/
public class Text_FadeIn : MonoBehaviour
{
    public Text txt;
	private float alpha = 0.0f; //Initial Opacity

	void Awake()
	{
		txt = GetComponent<Text> ();// Get the target Text

		txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, alpha); 

		StartCoroutine ("PlayText"); // Coroutine start
	}

	void Update()
	{	
		// if the value of opacity is bigger than 1 change scene to chp 1.1
		if(alpha >= 1.0f)
		{
			Invoke("ToChp1_1",1); 
		}
	}

	public void ToChp1_1()
    {
    	SceneManager.LoadScene("chp_1.1"); // scene load
    }

	IEnumerator PlayText()
	{
		// increase the value of the opacity by 0.01 for each 0.01 second
		while(alpha < 1.0f)
		{
			alpha += 0.01f;
			txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, alpha);
			yield return new WaitForSeconds (0.01f);
		}
	}
}
