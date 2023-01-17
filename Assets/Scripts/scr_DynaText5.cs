
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_DynaText5 : MonoBehaviour
{
    public bool start;

    public int t;
    public int l;
    public int i;

    public string line;

    private int j;
    private int delay;

    private string[] txt = new string[]{
      "Mike: Hier.",
      "de bedrijfsleider duwde een beker water in Steves hand",
      "Mike: Vertel, wat is er aan de hand. Je werkt de laatste tijd ongelofelijk veel en lang, waarom is dat?",
      "Steve slikte. Hij wou het niet vertellen. Wat zou Mike wel niet van hem denken? De schaamte kleurde zijn hele gezicht rood.",
      "Mike was ondertussen tegenover hem gaan staan, half tegen het bureau aan het leunend.",
      "Je gaat in ieder geval niet meer de vloer op vandaag, dat kan ik je verzekeren.",
      "e man nam Steve in zich op. De jongen zat ineengedoken over zijn bekertje water heen. Zijn haar was onverzorgd en zijn handen waren zacht aan het trillen.", 
      "Steve: Ik uhm, uhm...",
      "Steve kneep in de beker.",
      "Steve: Mijn vrienden wouden op vakantie met de groep en ik zei dat ik meeging… maar ik heb niet genoeg geld enneh… om dus mee te kunnen moet ik ergens geld vandaan halen…",
      "Mike: Dus ga je spijbelen om toch maar wat meer te kunnen werken. Je had je ouders toch ook kunnen vragen om wat geld bij te leggen?",
      "Steve reageerde verontwaardig.",
      "Ik wil die vakantie helemaal zelf kunnen betalen", 
      "Mike schudde zijn hoofd.",
      "Mike: Jongen dit ga je niet vol houden. Je school en werk gaan keihard achteruit.",
      "Je slaapt minder door al die late diensten en je leeft bijna alleen maar op energy drinks. Dit is niet goed.",
      "Steve keek verslagen naar de grond en mompelde",
      "Steve: maar ik wil zo graag mee...",
      "Het was een seconde stil voordat Mike een zucht slaakte.",
      "Mike: Ik heb wel een ander idee waardoor je wat sneller geld kan krijgen. Dan kun je in ieder geval wat minder werken.",
      "Steves ogen lichtten op.",
      "Steve: Echt?",
      "Mike rolde zijn ogen.",
      "Mike: Wist je dat je belasting kan terugvragen over je loon?",
      "Steve schudde zijn hoofd",
      "Steve: nee. Dat is wel super chill tho!",
      "Mike knikte geruststellend.",
      "mike: Ik kan je niet beloven dat het heel veel is, maar dat ligt eraan over hoeveel jaar je terugvraagt",
      "Steve: Huh, wat bedoel je?",
      "Mike: Je kunt tot 5 jaar geleden belasting terugvragen",
      "MIke keek kort naar zijn horloge.",
      "Maareh, ik ga jou nu naar huis sturen, kom morgenavond maar langs tegen 8 uur dan regelen we het even.",
      "Steve: knikte enthousiast en stond op.",
      "Mike: Ik stuur je wel een lijstje wat je mee moet nemen. Goed slapen vanavond ja?",
      "Steve: Zal ik doen! Werk ze!",
      "Mike: Yow!",
      "Mike zwaaide hem na en ging weer aan het werk. De klanten waren onrustig geworden.",

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
