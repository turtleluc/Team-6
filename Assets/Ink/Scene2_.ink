EXTERNAL ShowCharacter(characterName, position, mood) 
EXTERNAL HideCharacter(characterName)
EXTERNAL ChangeMood(characterName, mood)

VAR relationship_strength = 80
VAR mental_health = 50

VAR know_about_food_issue = false

{ShowCharacter("Friend", "Right", "Serious")}
 Mak: Yo Steve! kom ff! Jeroen heeft een goed idee. 
 {ShowCharacter("Alice", "Center", "Fine")}
 Jeroen: Ik dacht, laten we met z'n allen na dit semester een week op vakantie gaan... Naar Spanje! 
 {ChangeMood("Alice", "SadHappy")}
 {ShowCharacter("Player", "Left", "Fine")}
 Steve: Spanje? Ik ga mee! 
 {ChangeMood("Friend", "Upset")}
Jeroen: Maarrr, iedereen betaalt wel een deel mee natuurlijk. Sowieso de vliegticket, je eigen kamer en eten voor 3 dagen. De rest regel ik wel. 
 Jeroen: Dat is zo ongeveer 650 euro per persoon.
 {ChangeMood("Player", "Uncomfortable")}
 Steve: Klinkt redelijk… (was davy) 
Mak: prima, stuur dan even een betaalverzoek in de groepsapp.

Jeroen: Steve? 
 Steve: Hm? Oh ja klinkt goed, wanneer moet je het hebben?
Jeroen: Voor Juli is goed, duurt nog even voor de zomervakantie.
{ChangeMood("Alice", "Fine")}
Steve: Komt goed!
{HideCharacter("Alice")}
{HideCharacter("Player")}
{HideCharacter("Friend")}
    -> DONE