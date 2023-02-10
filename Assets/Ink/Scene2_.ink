EXTERNAL ShowCharacter(characterName, position, mood) 
EXTERNAL HideCharacter(characterName)
EXTERNAL ChangeMood(characterName, mood)

VAR relationship_strength = 80
VAR mental_health = 50

VAR know_about_food_issue = false

{ShowCharacter("Alice", "Right", "Serious")}
 Mak: Yo Steve! kom ff! Jeroen heeft een goed idee. 
 {ChangeMood("Alice", "Upset")}
  {ChangeMood("Alice", "Fine")}
 Jeroen: Ik dacht, laten we met z'n allen na dit semester een week op vakantie gaan... Naar Spanje! 
 {ChangeMood("Alice", "SadHappy")}
 {ShowCharacter("Player", "Left", "Fine")}
 Steve: Spanje? Ik ga mee! 
 {ChangeMood("Player", "Sad")}
  {ChangeMood("Alice", "Fine")}
Jeroen: Maarrr, iedereen betaalt wel een deel mee natuurlijk. Sowieso de vliegticket, je eigen kamer en eten voor 3 dagen. De rest regel ik wel. 
 Jeroen: Dat is zo ongeveer 650 euro per persoon.
 {ChangeMood("Alice", "Serious")}
Mak: prima, stuur dan even een betaalverzoek in de groepsapp.
{ChangeMood("Alice", "Fine")}
{ChangeMood("Player", "Uncomfortable")}
Jeroen: Steve? 
{ChangeMood("Player", "Fine")}
 Steve: Hm? Oh ja klinkt goed, wanneer moet je het hebben?
{ChangeMood("Player", "Sad")}
Jeroen: Voor Juli is goed, duurt nog even voor de zomervakantie.
{ChangeMood("Alice", "SadHappy")}
{ChangeMood("Player", "Fine")}
Steve: Komt goed!
{HideCharacter("Alice")}
{HideCharacter("Player")}
    -> DONE