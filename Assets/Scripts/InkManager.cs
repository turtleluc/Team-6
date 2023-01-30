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

 

  private void StartStory()
  {
    _story = new Story(_inkJsonAsset.text);
    DisplayNextLine();

    _story.BindExternalFunction("ShowCharacter", (string name, string position, string mood) 
    => _characterManager.ShowCharacter(name, position, mood));

    _story.BindExternalFunction("HideCharacter", (string name) 
    => _characterManager.HideCharacter(name));
  }
  
  public void DisplayNextLine()
  {
    if (!_story.canContinue) return;
    
    string text = _story.Continue(); // gets next line
    text = text?.Trim(); // removes white space from text
    _textField.text = text; // displays new text
   
  }

  private CharacterManager _characterManager;

  void Start()
  {
    _characterManager = FindObjectOfType<CharacterManager>();
    StartStory();
  }
}