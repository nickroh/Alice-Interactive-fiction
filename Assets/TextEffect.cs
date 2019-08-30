using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextEffect : MonoBehaviour
{
    // Start is called before the first frame update
	
	public Text txt;
	private string story;

	void Awake()
	{
		txt = GetComponent<Text> ();
		story = txt.text;
		txt.text ="";

		StartCoroutine ("PlayText");
	}

	IEnumerator PlayText()
	{

		foreach(char c in story)
		{
			txt.text += c;
			yield return new WaitForSeconds (0.07f);
		}
	}

}
