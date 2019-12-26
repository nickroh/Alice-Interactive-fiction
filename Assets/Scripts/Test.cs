using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 

public class Test : MonoBehaviour
{
	Dialogue dialogue;
    // Start is called before the first frame update
    void Start()
    {
        dialogue = Dialogue.instance;
    }

    public string[] s = new string[]
    {
    	"test sentence 1",
    	"test sentence 2",
    	"test sentence 3"
    };

    int index = 0;
    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
		{
			if(!EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
			{  
	         	if(!dialogue.isSpeaking || dialogue.isWaitingForUserInput)
	         	{
	         		if(index >= s.Length)
	         		{
	         			return;
	         		}
	         		Say(s[index]);
	         		index++;
	         	}
			}
		}

        else if(Input.GetMouseButtonDown(0)) 
		{
		   	 if(!dialogue.isSpeaking || dialogue.isWaitingForUserInput)
	         	{
	         		if(index >= s.Length)
	         		{
	         			return;
	         		}
	         		Say(s[index]);
	         		index++;
	         	}
		}

		void Say(string s)
		{
			dialogue.Say(s);
		}
    }
}
