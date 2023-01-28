# Loldle game:
The idea of this game is to write the names of League Of Legends champions until you get the right one, which is chosen randomly each time the game is started. All champions have 7 categories - Gender, Position, Species, Resource, Range Type, Region, Release Year. 
The list of all champions up to date can be found here: https://leagueoflegends.fandom.com/wiki/List_of_champions.

# How does the game work: 
Now I'll explain how the game works. Let's say for example the right champion is Aatrox. His categories are: Male | Top | Darkin, God-Warrior | Manaless | Melee | Runeterra, Shurima | 2013↑. 

# Gender Category: 
Then if you try to guess Ahri - she is Female. The "Female" will be coloured red. If you try to guess a Male champion - let's say - Sett - The "Male" will be coloured Green. 

# Position Category: 
Let's go back to the Ahri guess. Ahri is played in Position Mid - so the "Mid" is going to be red. Sett on the other hand is played in Top, which means it will light up green. There are champions which can be played in multiple positions, like Vayne, which is played in Top And Bot. If you try guessing her, the "Bot Top" will be coloured yellow, meaning only on of these 2 categories is correct(or one of the correct, because the right champion may have multiple positons, unlike Aatrox.Let's say the right champion is Mordekaiser(Top Jungle) and you try guessing Vayne(Bot Top) - the "Bot Top" will be coloured yelow. An Aatrox guess will also be coloured yellow). 

# Species Category: 
The "Species" work just like "Positions". 

# Resource Category: 
The "Resource" is pretty straight-forward - it works just like "Gender". 

# Range Type Category: 
There are 3 Range types - Melee, Ranged, Melee Ranged. If the right champion is Melee and you try guesing a Ranged champion - it will be coloured red. If you try guessing Melee champion it will be coloured green. If you try guessing Jayce(which is on of the rare examples of Melee Ranged), it will be coloured yellow. It's vice versa if the right champion is Ranged(Jayce guess will be yellow again). If the right champion is Melee Range, guessing a Melee or Ranged type champion, will result in them being coloured red. Guessing a Melee Range type champion will be coloured green.

# Region Category:
The "Region" works just like "Positions".

#Release Year Category: 
The "Release Year" works as follows. Let's use Aatrox for example. He is released in 2013. If you try guessing Ryze(released 2009) it will be printed - 2009↑ in colour red, meaning Ryze is released 2009, but the right champion is released at a later year. If you try guessing Yone(released 2020) it will be printed 2020↓ in colour red, meaning Yone is released 2020, but the right champion is released at an earlier year. If you try guessing Jinx(released 2013, just like Aatrox) it will be printed 2013 in colour green.

# Changes from the original game: 
The game is inspired by an online game called Loldle: https://loldle.net/classic. I've made a few changes tho. I've added a "Give up" command, which will reveal the right champion and his categories. Another change is the removal of the gender type - "Other" and replacing it will an accurate gender for the champion(And no, that doesn't mean I'm homophobic. Don't cancel me :D ).

# Changes to categories: I've also made some changes to The "Positions" and "Regions" of each champion, which feel correct to me:
Blitzcrank: Changed Gender from "Other" to "Male",
Ezreal: Added Runeterra to Region,
Katarina: Added Icathia to Region,
Kindred: Changed Gender from "Other" to "Female",
Lucian: Added Runeterra to Region,
Malphite: Added Mid to Positions,
Maokai: Added Jungle to Positions,
Pantheon: Added Top to Positions,
Senna: Added Runeterra to Region,
Seraphine: Added Mid and Support to Positions,
Sylas: Added Jungle to Positions,
Vladimir: Resource changed from "Bloodthirst" to "Health",
Zac: Added Top to Positions,
Zed: Added Jungle to Positions,
Zilean: Added Mid to Positions


# How does the code work?
Firstly all champions are added to a Dicitonary<string, List<string>>, where the string contains the champion name and the List contains the champion categories. 
All champion names are added to another List. Then a random number generator is implemented(from number 0 to the number of the List.Count). Then the random number which matches the index of the champion in the List is chosen as a right input.
3 more Dicitonary<string, List<string>> are created for the categories: "Positions", "Species", "Region", because they need to be splited one more time from the first dicitonary. The string once again contains the champion name, The List - one of the categories above(for example: Bot Top).
Then the program let's the user type an input. If the input is the same as the right champion, everything is coloured green and the program stops. 
 If the input isn't a League Of Legends champion at all or if you have a typo, it let's the user type another input. This reapeats until the user gives the program an existing League Of Legend champion. 
If the input isn't the right champion, but it's an existing champion there are a series of if else-s that check if the category should be coloured green, red or yellow.
As i mentioned there is a "Give up" command which prints the right champion and his categories, coloured in green.

# Updates and ownerships of the game  
Approximately every 3 months a new champion is added to League Of Legends, so I'll try and keep this game updated.
I do not claim ownership for the game, because I'm not the first person to make it. Link to the original game: https://loldle.net/classic
