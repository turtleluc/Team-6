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
  }
  
  public void DisplayNextLine()
  {
    if (!_story.canContinue) return;
    
    string text = _story.Continue(); // gets next line
    text = text?.Trim(); // removes white space from text
    _textField.text = text; // displays new text
  }
}