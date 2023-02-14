EXTERNAL ShowCharacter(characterName, position, mood) 
EXTERNAL HideCharacter(characterName)
EXTERNAL ChangeMood(characterName, mood)

VAR relationship_strength = 80
VAR mental_health = 50

VAR know_about_food_issue = false


{ShowCharacter("Player", "Left", "Sad")}
{ShowCharacter("Alice", "Right", "Sad")}
Mike: Daar ben ik weer, frituur stond weer eens te hoog. 
Mike: Had je m’n berichtje nog gelezen?
{ChangeMood("Alice", "Serious")}
{ChangeMood("Player", "Uncomfortable")}
Steve: Ja hier zijn ze.
{ChangeMood("Alice", "Sad")}
{ChangeMood("Player", "Upset")}
Mike: Top, mag je dit voor me invullen. Klik nu op de monitor 
Mike: Okay, nu gaan we naar aangifte inkomstenbelasting en dan mag checken je of al je persoonsgegevens kloppen en daarna mag je je telefoonnummer invullen. 
Mike: Goed nu komt het lange gedeelte. Hier mag je de vakjes aanklikken die voor jou van toepassing zijn. Dus dingen zoals ‘dit jaar getrouwd’ mag je openlaten. 
{ChangeMood("Alice", "Serious")}
{ChangeMood("Player", " Uncomfortable")}
Steve: en nu?
{ChangeMood("Alice", "Sad")}
{ChangeMood("Player", "Upset")}
Mike: Nu komen je jaaropgave van te pas. Je vult hier je loon, loonheffing, arbeiderskorting en levensloopverlofkorting in. 
Mike: Ja moeilijk woord levensloopverlofkorting. Simpel gezegd zijn dat je vakantie uren die jij hebt opgenomen. 
Mike: Je loon staat hier, loonheffing hiero en je arbeiderskorting staat hieronder.
Mike: En dan vul je de reiskosten nog in en klaar alweer. Best simpel eigenlijk? 
{ChangeMood("Alice", "Serious")}
{ChangeMood("Player", "Uncomfortable")}
Steve: Ja, dat had ik niet verwacht. 
Steve: Wanneer krijg ik het geld dan binnen? 
{ChangeMood("Alice", "Sad")}
{ChangeMood("Player", "Upset")}
Mike: Binnen één week krijg je bericht dat je geld terugkrijgt waarna je na een klein maandje het geld krijgt, als dat niet zo is moet je bellen met de belastingdienst. 
{ChangeMood("Alice", "Serious")}
{ChangeMood("Player", "Fine")}
Steve: Cool, dan verstuur ik hem. Dankjewel voor je hulp! 
{ChangeMood("Alice", "Crying")}
{ChangeMood("Player", "Upset")}
Mike: Geen probleem en als je op een ander moment hulp nodig hebt moet je het gewoon zeggen. 
{ChangeMood("Alice", "Serious")}
{ChangeMood("Player", "Fine")}
Steve: Zal ik doen baas!
Mike: Hey tot volgende week, niet moe zijn! 
Steve: Nee, nee. 
Steve: Nou doei! 
    {HideCharacter("Alice")}    
    {HideCharacter("Player")}
Het invullen was gelukt! Nu alleen nog afwachten op het geld en dan was het zover. Hij kon mee naar Spanje!
     Druk op volgende.