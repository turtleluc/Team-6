
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_DynaText3 : MonoBehaviour
{
    public bool start;

    public int t;
    public int l;
    public int i;

    public string line;

    private int j;
    private int delay;

    private string[] txt = new string[]{
      "Steve stapte Wackies binnen. Hij had een plan bedacht om aan het einde van de maand het geld bij elkaar te hebben.",
      "Steve: ''Als je nog open diensten hebt geef ze dan maar aan mij! Ik heb meer tijd deze maand.''",
      "Mike trok een wenkbrauw op.",
      "Mike: ''weet je dat zeker? Niet zo'n hele belangrijke afspraak zoals school?''",
      "Steve: ''Ik heb eerder vrij omdat ons groepje al klaar is met het project.''",
      "Mike: ''Als jij het zegt dan heb ik nog een shift open voor woensdag om…''",
      "_",
      "Steve stond in de keuken. In gedachten verzonken draaide hij twee burgers om.",
      "Hij had vijf diensten overgenomen en twee verlengd.",
      "Nu moest hij voor 6 uur opstaan en de laatste 2 uren spijbelen, maar hij had het ervoor over. Anders hoorde hij er niet bij als hij als enige niet mee ging.", 
      "Stel je voor dat ze leuke dingen gingen doen!",
      "En wanneer ze weer terug zijn gaan ze geheid alleen maar praten over hoe leuk Spanje nou was terwijl Steve er maar een beetje awkward bij moet lachen. Gaat nooit gebeuren!",
      "Hij draaide de burgers om en legde een broodje open.", "'Ik zal ze laten zien dat ik 650 euro in mijn eentje kan betalen!'",
      "Vast beraden maakte hij het broodje af en gooide patat in de frituur.", 
      "Steve: ''Dit gaat allemaal goed komen…''",
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
