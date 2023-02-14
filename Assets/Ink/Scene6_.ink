EXTERNAL ShowCharacter(characterName, position, mood) 
EXTERNAL HideCharacter(characterName)
EXTERNAL ChangeMood(characterName, mood)

VAR relationship_strength = 80
VAR mental_health = 50

VAR know_about_food_issue = false

 zijn scherm stond het lijstje van Mike. Wat hij mee moest nemen waren: 

ID-kaart, Jaaropgave(n) ,Bankpas en telefoon, maar die vergeet je toch niet ;)  
{ShowCharacter("Player", "Left", "Sad")}
Hij checkte snel zijn portemonnee. Zijn ID en bankpas zaten in hun vertrouwelijke vakje.
{ChangeMood("Player", "Fine")}
Steve: Check. 
{ChangeMood("Player", "Sad")}
Steve ging achter zijn computer zitten. 
Een jaaropgave zou zo gepiept moeten zijn. 
Na wat rondzoeken op Werknemersloket had hij het bestand gevonden en stuurde het door naar zijn printer. 
Het oude ding ging gehoorzaam aan het werk. Tegelijkertijd kleedde Steve zich aan en pakte zijn tas. Toen hij terugkwam in zijn kamer lag de vloer onder het papier.
{ChangeMood("Player", "Surprised")}
Steve: Verdorie, moet dit weer? 
{ChangeMood("Player", "Sad")}
Hij sloeg een diepe zucht, blijkbaar was hij vergeten het bakje uit te schuiven.  

Wanneer Steve zijn jaaropgaves had opgepakt checkte hij het lijstje nog een keer. Toen hij tevreden was liep hij de deur uit naar school.
    {HideCharacter("Player")}
     Druk op volgende.