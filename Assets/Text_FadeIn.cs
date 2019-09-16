using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Text_FadeIn : MonoBehaviour
{
    public Text txt;
	private float alpha = 0.0f;

	void Awake()
	{
		txt = GetComponent<Text> ();
		txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, alpha);

		StartCoroutine ("PlayText");
	}

	void Update()
	{
		if(alpha >= 1.0f)
		{
			Invoke("ToChp1_1",2);
		}
	}

	public void ToChp1_1()
    {
    	SceneManager.LoadScene("chp_1.1");
    }

	IEnumerator PlayText()
	{
		while(alpha < 1.0f)
		{
			alpha += 0.01f;
			txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, alpha);
			yield return new WaitForSeconds (0.01f);
		}
	}
}
