/*
	Text Typing Effect
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextShow : MonoBehaviour
{
	public Text txt;
	private string story;

	void Awake()
	{
		txt = GetComponent<Text> (); // Get the Target Text
		story = txt.text;
		txt.text =""; // Reset Text 
		
		StartCoroutine ("PlayText"); // Start Coroutine
	}

	IEnumerator PlayText()
	{

		foreach(char c in story) // Show each letter at intervals of 0.03 second
		{
			txt.text += c;
			yield return new WaitForSeconds (0.03f);
		}
	}
}
