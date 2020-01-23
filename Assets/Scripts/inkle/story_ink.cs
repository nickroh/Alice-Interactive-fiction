using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

public class story_ink : MonoBehaviour
{
	public TextAsset inkJSON;
	private Story story;

	public Text textPrefab;
	public Button buttonPrefab;
    // Start is called before the first frame update
    void Start()
    {
        story = new Story(inkJSON.text);

        Text storyText = Instantiate(textPrefab) as Text;
        storyText.text = loadStoryChunk();
        storyText.transform.SetParent(this.transform,false);

        Debug.Log(loadStoryChunk());
        for(int i = 0; i< story.currentChoices.Count;i++)
        {
        	Debug.Log(story.currentChoices[i].text);
        }

        story.ChooseChoiceIndex(0);

        Debug.Log(loadStoryChunk());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string loadStoryChunk()
    {
    	string text = "";
    	if(story.canContinue)
    	{
    		text = story.ContinueMaximally();
    	}
    	return text;
    	
    }
}
