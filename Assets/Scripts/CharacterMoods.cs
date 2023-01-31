using Assets.Scripts;
using UnityEngine;

public class CharacterMoods : MonoBehaviour
{
  public CharacterName Name;

  public Sprite Normaal;
  public Sprite Blij;
  public Sprite Bang;
  public Sprite Verdrietig;
  public Sprite Verrast;
  public Sprite Ongemakkelijk;
  public Sprite Boos;
  public Sprite Praat1;
  public Sprite Praat2;

  public Sprite GetMoodSprite(CharacterMood mood)
  {
    switch (mood)
    {
      case CharacterMood.Normaal:
      return Normaal;
      
      case CharacterMood.Blij:
      return Blij ?? Normaal;
      
      case CharacterMood.Verdrietig:
      return Verdrietig ?? Normaal;
      
      case CharacterMood.Verrast:
      return Normaal ?? Normaal;
      
      case CharacterMood.Ongemakkelijk:
      return Ongemakkelijk ?? Normaal;

      case CharacterMood.Boos:
      return Boos ?? Normaal;

      case CharacterMood.Praat1:
      return Praat1 ?? Normaal;

      case CharacterMood.Praat2:
      return Praat2 ?? Normaal;     
      
      default:
      Debug.Log($"Didn't find Sprite for character: {Name}, mood: {mood}");
      return Normaal;  
    }
  }
}