EXTERNAL ShowCharacter(characterName, position, mood) 
EXTERNAL HideCharacter(characterName)
EXTERNAL ChangeMood(characterName, mood)

VAR relationship_strength = 80
VAR mental_health = 50

VAR know_about_food_issue = false

{ShowCharacter("Steve", "Left", "Normaal")}
Steve: Check. 
{ChangeMood("Steve", "Praat1")}
Steve: godsamme, moet dit weer? 

    -> DONE
