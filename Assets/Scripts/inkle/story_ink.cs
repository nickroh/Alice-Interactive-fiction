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
       
        storyText.text = text;
        storyText.transform.SetParent(this.transform, false);

        foreach (Choice choice in story.currentChoices)
        {

           
            

            Text choiceText = buttonPrefab.GetComponentInChildren<Text>();
            choiceText.text = choice.text;
             Button choiceButton = Instantiate(buttonPrefab) as Button;
             choiceButton.transform.SetParent(this.transform, false);
            Debug.Log(choiceText.text);

            choiceButton.onClick.AddListener(delegate {
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
}
