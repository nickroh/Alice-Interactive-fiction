using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Text_Show : MonoBehaviour
{
    public Text txt;
	private string story;
	public float txt_speed;

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
			yield return new WaitForSeconds (txt_speed);
		}
	}
}
