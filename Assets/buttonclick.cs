using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonclick : MonoBehaviour
{
	public AudioSource clicksound; 
    // Start is called before the first frame update
   	public void click()
   	{
   		clicksound.Play();
   	}	
}
