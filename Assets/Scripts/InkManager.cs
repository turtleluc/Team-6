using Ink.Runtime;
using UnityEngine;
using UnityEngine.UI;

public class InkManager : MonoBehaviour
{
  [SerializeField]
  private TextAsset _inkJsonAsset;
  private Story _story;

  [SerializeField]
  private Text _textField;

 



  void Start()
  {
    StartStory();
  }

  private void StartStory()
  {
    _story = new Story(_inkJsonAsset.text);
    DisplayNextLine();

    _story.BindExternalFunction("ShowCharacter", (string name, string position, string mood) 
    => Debug.Log($"Show character called. {name}, {position}, {mood}"));

    _story.BindExternalFunction("HideCharacter", (string name) 
    => Debug.Log($"Hide character called. {name}"));
  }
  
  public void DisplayNextLine()
  {
    if (!_story.canContinue) return;
    
    string text = _story.Continue(); // gets next line
    text = text?.Trim(); // removes white space from text
    _textField.text = text; // displays new text
   
  }
  public void ShowCharacter(CharacterName name, CharacterPosition position, CharacterMood mood)
{
  var character = _characters.FirstOrDefault(x => x.Name == name);

  if (character == null)
  {
    var characterObject = Instantiate(_characterPrefab, gameObject.transform, false);

    character = characterObject.GetComponent<Character>();

    _characters.Add(character);
  }
  else if (character.IsShowing)
  {
    Debug.LogWarning($"Failed to show character {name}. Character already showing");
    return;
  }

  character.Init(name, position, mood, GetMoodSetForCharacter(name));
}
}