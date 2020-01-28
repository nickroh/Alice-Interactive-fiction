using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

public class story_ink : MonoBehaviour
{
	public TextAsset inkJSON;
    private Story story;

    public float txt_speed;

    public Text textPrefab;
    public Button buttonPrefab;

    private IEnumerator coroutine;

    // Start is called before the first frame update
    void Start()
    {
        story = new Story(inkJSON.text);

        refreshUI();

    }

    void refreshUI()
    {

        eraseUI();

        Text storyText = Instantiate(textPrefab) as Text;

        string text = loadStoryChunk();

        List<string> tags = story.currentTags;

        if(tags.Count > 0)
        {
            text = "<b>" + tags[0] + "</b> - " + text;
        }
       
        // PlayText();
        storyText.transform.SetParent(this.transform, false);
		//storyText.text = text;

        coroutine= PlayText(text, storyText);
		StartCoroutine(coroutine);
        foreach (Choice choice in story.currentChoices)
        {

            Text choiceText = buttonPrefab.GetComponentInChildren<Text>();
            choiceText.text = choice.text;
            Button choiceButton = Instantiate(buttonPrefab) as Button;
            choiceButton.transform.SetParent(this.transform, false);
            //Debug.Log(choiceText.text);

            choiceButton.onClick.AddListener(delegate {
                StopCoroutine(coroutine);
                chooseStoryChoice(choice);
            });

        }
    }

    void eraseUI()
    {
        for(int i = 0; i < this.transform.childCount; i++)
        {
            Destroy(this.transform.GetChild(i).gameObject);
        }
    }

    void chooseStoryChoice(Choice choice)
    {
        story.ChooseChoiceIndex(choice.index);
        refreshUI();
    }

    // Update is called once per frame
    void Update()
    {

    }

    string loadStoryChunk()
    {
        string text = "";

        if (story.canContinue)
        {
            text = story.ContinueMaximally();
        }

        return text;
    }

    IEnumerator PlayText(string text, Text storyText)
	{

		foreach(char c in text)
		{
			Debug.Log(c);
			storyText.text += c;
			yield return new WaitForSeconds (txt_speed);
		}
	}
}
