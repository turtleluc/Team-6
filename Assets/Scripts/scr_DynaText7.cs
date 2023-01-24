
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_DynaText7 : MonoBehaviour
{
    public bool start;

    public int t;
    public int l;
    public int i;

    public string line;

    private int j;
    private int delay;

    private string[] txt = new string[]{
      "Mike: Nou ben ik weer, frituur stond weer eens te hoog.",
     "Mike: Had je m’n berichtje nog gelezen?",
      "Steve: Ja hier zijn ze.",
      "Mike: Top, mag je dit voor me invullen.", 
      "Mike: Okay, nu gaan we naar aangifte inkomstenbelasting en dan mag checken je of al je persoonsgegevens kloppen en daarna mag je je telefoonnummer invullen.",
      "Mike: Goed nu komt het lange gedeelte. Hier mag je de vakjes aanklikken die voor jou van toepassing zijn. Dus dingen zoals ‘dit jaar getrouwd’ mag je openlaten.",
       "Steve: en nu?", 
      "Mike: Nu komen je jaaropgave van te pas. Je vult hier je loon, loonheffing, arbeiderskorting en levensloopverlofkorting in.",
      "Ja moeilijk woord levensloopverlofkorting. Simpel gezegd zijn dat je vakantie uren die jij hebt opgenomen.",
      "Je loon staat hier, loonheffing hiero en je arbeiderskorting staat hieronder.",
      "Mike: En dan vul je de reiskosten nog in en klaar alweer. Best simpel eigenlijk?",
      "Steve: Ja, dat had ik niet verwacht",
      "Steve: Wanneer krijg ik het geld dan binnen?",
      "Mike: Binnen één week krijg je bericht dat je geld terugkrijgt waarna je na een klein maandje het geld krijgt, als dat niet zo is moet je bellen met de belastingdienst.",
      "Steve: Cool, dan verstuur ik hem. Dankjewel voor je hulp!",
      "mike: geen probleem en als je op een ander moment hulp nodig hebt moet je het gewoon zeggen.",
     "Steve: Zal ik doen baas!",
      "MIke: Hey tot volgende week, niet moe zijn!",
      "Steve: Nee, nee.",
      "Steve: Nou doei!",
      "Het invullen was gelukt! Nu alleen nog afwachten op het geld en dan was het zover. Hij kon mee naar Spanje!", 

    };

    public Text textElement;
    // Start is called before the first frame update
    void Start()
    {
      line = "";
      textElement.text = line;
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButtonDown(0))      
      {
          start = !start;
      }

      if (Input.GetMouseButtonUp(0))
      {
        if(l < txt[i].Length)
      	{
      		l = txt[i].Length;
      	}
      	else
      	{
      		l = 0;
      		if(i < txt.Length-1)
      		{
      			i++;
      		}
      		else
      		{
      			i = 0;
      		}
      	}
      }

      if(start == true)
      {
        t++;
      }

      j = 0;
      delay = 5;

      if(t >= delay)
      {
        /*
      	if l < string_length(text[i])
      	{
      		if string_char_at(text[i],l) != " "
      		{
      			audio_sound_pitch(snd_Tick,irandom_range(4,8));
      			audio_play_sound(snd_Tick,0,0);
      		}
      	}*/
      	l++;
      	t = 0;
      }

      while(j<=txt[i].Length && j<=l)
      {
      	line = txt[i].Substring(0,j);
      	j++;
      }

      textElement.text = line;
    }
}
