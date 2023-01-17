
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_DynaText6 : MonoBehaviour
{
    public bool start;

    public int t;
    public int l;
    public int i;

    public string line;

    private int j;
    private int delay;

    private string[] txt = new string[]{
      "De wekker ging af om 10 uur. Steve stond met moeite op en greep naar zijn telefoon om de wekker uit te zetten. ",
      "Hij was door drie wekkers heen geslapen, maar dat kon hem niet meer schelen want op zijn scherm stond het lijstje van Mike.",
      "Wat hij mee moest nemen waren: ID-kaart, Jaaropgave(n), Bankpas en Telefoon, maar die vergeet je toch niet ;)",
      "Hij checkte snel zijn portemonnee. Zijn ID en bankpas zaten in hun vertrouwelijke vakje.",
      "Steve: Check.",
      "Steve ging achter zijn computer zitten. Een jaaropgave zou zo gepiept moeten zijn.",
      "Na wat rondzoeken op Werknemersloket had hij het bestand gevonden en stuurde het door naar zijn printer.",
      " Het oude ding ging gehoorzaam aan het werk. Tegelijkertijd kleedde Steve zich aan en pakte zijn tas. Toen hij terugkwam in zijn kamer lag de vloer onder het papier.",
      "Steve: godsamme, moet dit weer?",
      "Hij sloeg een diepe zucht, blijkbaar was hij vergeten het bakje uit te schuiven.",
      "Wanneer Steve zijn jaaropgaves had opgepakt checkte hij het lijstje nog een keer. Toen hij tevreden was liep hij de deur uit naar school.",

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
