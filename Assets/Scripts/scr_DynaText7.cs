
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
      "Steve zat in Mikes kantoor. Mike moest nog iets regelen voordat hij ook kantoor weer binnenkwam.",
      "Mike: Nou ben ik weer, frituur stond weer eens te hoog.",
      "Mike schoof bij het bureau aan.",
      "Mike: Had je m’n berichtje nog gelezen?",
      "vroeg hij terwijl hij de computer opstartte. Steve knikte en legde zijn jaaropgaves neer.",
      "Steve: Ja hier zijn ze.",
      "Mike: Top, mag je dit voor me invullen.", 
      "Hij duwde het computerscherm naar Steve toe. Hij had de website van de belastingdienst erbij gepakt en het vroeg om zijn DigiD. Steve opende de app en logde in.",
      "Mike: Okay, nu gaan we naar aangifte inkomstenbelasting en dan mag checken je of al je persoonsgegevens kloppen en daarna mag je je telefoonnummer invullen.",
      "Steve knikte en ging door het lijstje heen. Toen hij er zeker van was vulde hij zijn nummer in en klikte op doorgaan.",
      "Mike: Goed nu komt het lange gedeelte. Hier mag je de vakjes aanklikken die voor jou van toepassing zijn. Dus dingen zoals ‘dit jaar getrouwd’ mag je openlaten.",
      "Mike liet Steve zijn antwoorden invullen en leunde achterover. Na een minuutje was Steve klaar.",
      "Seve: en nu?", 
      "Mike: Nu komen je jaaropgave van te pas. Je vult hier je loon, loonheffing, arbeiderskorting en levensloopverlofkorting in.",
      "Ja moeilijk woord levensloopverlofkorting. Simpel gezegd zijn dat je vakantie uren die jij hebt opgenomen.",
      "Je loon staat hier, loonheffing hiero en je arbeiderskorting staat hieronder.",
      "Mike wees de plekken aan op Steves jaaropgave.",
      "Mike: En dan vul je de reiskosten nog in en klaar alweer. Best simpel eigenlijk?",
      "Steve: Ja, dat had ik niet verwacht",
      "zei Steve terwijl hij de getallen invoert",
      "Steve: Wanneer krijg ik het geld dan binnen?",
      "Mike: Binnen één week krijg je bericht dat je geld terugkrijgt waarna je na een klein maandje het geld krijgt, als dat niet zo is moet je bellen met de belastingdienst.",
      "Steve knikte.",
      "Steve: Cool, dan verstuur ik hem. Dankjewel voor je hulp!",
      "Maik nam de computer terug",
      "mike: geen probleem en als je op een ander moment hulp nodig hebt moet je het gewoon zeggen.",
      "Steve stak zijn duim omhoog.",
      "Steve: Zal ik doen baas!",
      "MIke: Hey tot volgende week, niet moe zijn!",
      "Steve: Nee, nee.",
      "Steve glimlachte en liep het kantoor uit.",
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
