using UnityEngine;
using System.Collections;

public class ContentView : StoryElementView {

	public TypedText textTyper;
	private RichTextSubstring richText;

	public Color driedColor;
	public Color wetColor;

	protected override void Awake () {
		textTyper = new TypedText();
		text.color = wetColor;
		base.Awake();
	}

	protected override void Update () {
		base.Update ();
		if(textTyper.typing) {
			textTyper.Loop();
			if((Main.Instance.gameState.hasMadeAChoice || Application.isEditor) && Input.GetMouseButtonDown(0)) {
				textTyper.ShowInstantly();
			}
		}
	}

	public override void LayoutText (string content) {
		//base.LayoutText (content);

		TypedText.TypedTextSettings textTyperSettings = new TypedText.TypedTextSettings();
		textTyperSettings.customPostTypePause.Add(new TypedText.CustomStringTimeDelay(",", new TypedText.RandomTimeDelay(0.075f,0.1f)));
		textTyperSettings.customPostTypePause.Add(new TypedText.CustomStringTimeDelay(":", new TypedText.RandomTimeDelay(0.125f,0.175f)));
		textTyperSettings.customPostTypePause.Add(new TypedText.CustomStringTimeDelay("-", new TypedText.RandomTimeDelay(0.125f,0.175f)));
		textTyperSettings.customPostTypePause.Add(new TypedText.CustomStringTimeDelay(".", new TypedText.RandomTimeDelay(0.3f,0.4f)));
		textTyperSettings.customPostTypePause.Add(new TypedText.CustomStringTimeDelay("\n", new TypedText.RandomTimeDelay(0.5f,0.6f)));
		if(Main.Instance.gameState.hasMadeAChoice) {
			textTyperSettings.splitMode = TypedText.TypedTextSettings.SplitMode.Character;
			textTyperSettings.defaultTypeDelay = new TypedText.RandomTimeDelay(0.06f,0.09f);
		} else {
			textTyperSettings.splitMode = TypedText.TypedTextSettings.SplitMode.Character;
			textTyperSettings.defaultTypeDelay = new TypedText.RandomTimeDelay(0.05f,0.09f);
		}

		richText = new RichTextSubstring (content);
		textTyper = new TypedText();
		textTyper.OnTypeText += OnTypeText;
		textTyper.OnCompleteTyping += CompleteTyping;
		textTyper.TypeText(richText.plainText, textTyperSettings);

		// richText = new RichTextSubstring (content);
		// textTyper = new TypedText();
		// textTyper.OnTypeText += "c";
		// textTyper.OnCompleteTyping += "b";
		// textTyper.TypeText(richText.plainText, textTyperSettings);

	}

	void OnTypeText (string newText) {
		text.text = richText.Substring(0, textTyper.text.Length);
		if(newText != " ")
			AudioClipDatabase.Instance.PlayKeySound ();
	}

	protected override void CompleteTyping () {
		colorTween.Tween(text.color, driedColor, 8);
		base.CompleteTyping();
	}
}
