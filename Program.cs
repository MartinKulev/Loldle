using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Loldle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Gender | Positions | Species | Resource | Range Type | Region | Release Year");
            string input = Console.ReadLine();

            int checker1 = 0;
            int checker2 = 0;
            int checker3 = 0;

            Dictionary<string, List<string>> champions = new Dictionary<string, List<string>>();
            champions.Add("Aatrox", new List<string> { "Male", "Top", "Darkin God-Warrior", "Manaless", "Melee", "Runeterra Shurima", "2013" });
            champions.Add("Ahri", new List<string> { "Female", "Mid", "Vastayan", "Mana", "Ranged", "Ionia", "2011" });
            champions.Add("Akali", new List<string> { "Female", "Mid Top", "Human", "Energy", "Melee", "Ionia", "2010" });
            champions.Add("Akshan", new List<string> { "Male", "Mid Top", "Human", "Mana", "Ranged", "Shurima", "2021" });
            champions.Add("Alistar", new List<string> { "Male", "Support", "Minotaur", "Mana", "Melee", "Runeterra", "2009" });
            champions.Add("Amumu", new List<string> { "Male", "Jungle Support", "Undead Yordle", "Mana", "Melee", "Shurima", "2009" });
            champions.Add("Anivia", new List<string> { "Female", "Mid", "God Spirit", "Mana", "Ranged", "Freljord", "2009" });
            champions.Add("Annie", new List<string> { "Female", "Mid", "Human Magicborn", "Mana", "Ranged", "Runeterra", "2009" });
            champions.Add("Aphelios", new List<string> { "Male", "Bot", "Human Spiritualist", "Mana", "Ranged", "Targon", "2019" });
            champions.Add("Ashe", new List<string> { "Female", "Bot Support", "Human Iceborn", "Mana", "Ranged", "Freljord", "2009" });
            champions.Add("Aurelion Sol", new List<string> { "Male", "Mid", "Celestial Dragon", "Mana", "Ranged", "Runeterra Targon", "2016" });
            champions.Add("Azir", new List<string> { "Male", "Mid", "God-Warrior", "Mana", "Ranged", "Shurima", "2014" });
            champions.Add("Bard", new List<string> { "Male", "Support", "Celestial", "Mana", "Ranged", "Runeterra", "2015" });
            champions.Add("Bel'Veth", new List<string> { "Female", "Jungle", "Void-Being", "Manaless", "Melee", "Void", "2022" });
            champions.Add("Blitzcrank", new List<string> { "Male", "Support", "Golem", "Mana", "Melee", "Zaun", "2009" });//Changed Gender from "Other" to "Male"
            champions.Add("Brand", new List<string> { "Male", "Mid Support", "Human MagicallyAltered", "Mana", "Ranged", "Runeterra", "2011" });
            champions.Add("Braum", new List<string> { "Male", "Support", "Human Iceborn", "Mana", "Melee", "Freljord", "2014" });
            champions.Add("Caitlyn", new List<string> { "Female", "Bot", "Human", "Mana", "Ranged", "Piltover", "2011" });
            champions.Add("Camile", new List<string> { "Female", "Top", "Cyborg Human", "Mana", "Melee", "Piltover", "2016" });
            champions.Add("Cassiopeia", new List<string> { "Female", "Mid", "Human MagicallyAltered", "Mana", "Ranged", "Noxus Shurima", "2010" });
            champions.Add("Cho'Gath", new List<string> { "Male", "Top", "Void-Being", "Mana", "Melee", "Void", "2009" });
            champions.Add("Corki", new List<string> { "Male", "Mid", "Yordle", "Mana", "Ranged", "BandleCity", "2009" });
            champions.Add("Darius", new List<string> { "Male", "Top", "Human", "Mana", "Melee", "Noxus", "2012" });
            champions.Add("Diana", new List<string> { "Female", "Jungle Mid", "Aspect Human", "Mana", "Melee", "Targon", "2012" });
            champions.Add("Draven", new List<string> { "Male", "Bot", "Human", "Mana", "Ranged", "Noxus", "2012" });
            champions.Add("Dr. Mundo", new List<string> { "Male", "Top", "ChemicallyAltered Human", "Health", "Melee", "Zaun", "2009" });//Removed Jungle from Positions
            champions.Add("Ekko", new List<string> { "Male", "Jungle Mid", "Human", "Mana", "Melee", "Zaun", "2015" });
            champions.Add("Elise", new List<string> { "Female", "Jungle", "Human MagicallyAltered", "Mana", "Melee Ranged", "Noxus ShadowIsles", "2012" });
            champions.Add("Evelynn", new List<string> { "Female", "Jungle", "Demon Spirit", "Mana", "Melee", "Runeterra", "2009" });
            champions.Add("Ezreal", new List<string> { "Male", "Bot", "Human Magicborn", "Mana", "Ranged", "Piltover Runeterra", "2010" });//Added Runeterra to Region
            champions.Add("Fiddlesticks", new List<string> { "Male", "Jungle", "Demon Spirit", "Mana", "Ranged", "Runeterra", "2009" });
            champions.Add("Fiora", new List<string> { "Female", "Top", "Human", "Mana", "Melee", "Demacia", "2012" });
            champions.Add("Fizz", new List<string> { "Male", "Mid", "Yordle", "Mana", "Melee", "Bilgewater", "2011" });
            champions.Add("Galio", new List<string> { "Male", "Mid Support", "Golem", "Mana", "Melee", "Demacia", "2010" });
            champions.Add("Gankplank", new List<string> { "Male", "Mid Top", "Human", "Mana", "Melee", "Bilgewater", "2009" });//Added Mid to Positions
            champions.Add("Garen", new List<string> { "Male", "Top", "Human", "Manaless", "Melee", "Demacia", "2010" });
            champions.Add("Gnar", new List<string> { "Male", "Top", "Yordle", "Rage", "Melee Ranged", "Freljord", "2014" });
            champions.Add("Gragas", new List<string> { "Male", "Jungle Top", "Human", "Mana", "Melee", "Freljord", "2010" });
            champions.Add("Graves", new List<string> { "Male", "Jungle", "Human", "Mana", "Ranged", "Bilgewater", "2011" });
            champions.Add("Gwen", new List<string> { "Female", "Top", "Human MagicallyAltered", "Mana", "Melee", "Camavor ShadowIsles", "2021" });
            champions.Add("Hecarim", new List<string> { "Male", "Jungle", "Undead", "Mana", "Melee", "Camavor ShadowIsles", "2012" });
            champions.Add("Heimerdinger", new List<string> { "Male", "Mid Top", "Yordle", "Mana", "Ranged", "Piltover", "2009" });
            champions.Add("Illaoi", new List<string> { "Female", "Top", "Human Spiritualist", "Mana", "Melee", "Bilgewater", "2015" });
            champions.Add("Irelia", new List<string> { "Female", "Mid Top", "Human Spiritualist", "Mana", "Melee", "Ionia", "2010" });
            champions.Add("Ivern", new List<string> { "Male", "Jungle", "Human MagicallyAltered", "Mana", "Ranged", "Freljord Ionia", "2016" });
            champions.Add("Janna", new List<string> { "Female", "Support", "God Spirit", "Mana", "Ranged", "Shurima Zaun", "2009" });
            champions.Add("Jarvan IV", new List<string> { "Male", "Jungle", "Human", "Mana", "Melee", "Demacia", "2011" });
            champions.Add("Jax", new List<string> { "Male", "Jungle Top", "Unknown", "Mana", "Melee", "Icathia Runeterra Shurima", "2009" });
            champions.Add("Jayce", new List<string> { "Male", "Mid Top", "Human", "Mana", "Melee Ranged", "Piltover", "2012" });
            champions.Add("Jhin", new List<string> { "Male", "Bot", "Human Spiritualist", "Mana", "Ranged", "Ionia", "2016" });
            champions.Add("Jinx", new List<string> { "Female", "Bot", "ChemicallyAltered Human", "Mana", "Ranged", "Zaun", "2013" });
            champions.Add("Kai'Sa", new List<string> { "Female", "Bot", "Human Void-Being", "Mana", "Ranged", "Icathia Shurima Void", "2018" });//Added Icathia to Region
            champions.Add("Kalista", new List<string> { "Female", "Bot", "Undead", "Mana", "Ranged", "Camavor ShadowIsles", "2014" });
            champions.Add("Karma", new List<string> { "Female", "Support", "Human Spiritualist", "Mana", "Ranged", "Ionia", "2011" });
            champions.Add("Karthus", new List<string> { "Male", "Jungle", "Undead", "Mana", "Ranged", "Noxus ShadowIsles", "2009" });
            champions.Add("Kassadin", new List<string> { "Male", "Mid", "Human Void-Being", "Mana", "Melee", "Icathia Shurima Void", "2009" });//Added Icathia to Region
            champions.Add("Katarina", new List<string> { "Female", "Mid", "Human", "Manaless", "Melee", "Noxus", "2009" });
            champions.Add("Kayle", new List<string> { "Female", "Top", "Aspect Human MagicallyAltered", "Mana", "Melee Ranged", "Demacia Targon", "2009" });
            champions.Add("Kayn", new List<string> { "Male", "Jungle", "Darkin Human MagicallyAltered", "Mana", "Melee", "Ionia Noxus Runeterra Shurima", "2017" });
            champions.Add("K'Sante", new List<string> { "Male", "Top", "Human", "Mana", "Melee", "Shurima", "2022" });
            champions.Add("Kennen", new List<string> { "Male", "Mid Top", "Yordle", "Energy", "Ranged", "Ionia", "2010" });
            champions.Add("Kha'Zix", new List<string> { "Male", "Jungle", "Void-Being", "Mana", "Melee", "Void", "2012" });
            champions.Add("Kindred", new List<string> { "Female", "Jungle", "God Spirit", "Mana", "Ranged", "Runeterra", "2015" });//Changed Gender from "Other" to "Female"
            champions.Add("Kled", new List<string> { "Male", "Top", "Yordle", "Courage", "Melee", "Noxus", "2016" });
            champions.Add("Kog'Maw", new List<string> { "Male", "Bot", "Void-Being", "Mana", "Ranged", "Void", "2010" });
            champions.Add("LeBlanc", new List<string> { "Female", "Mid", "Human MagicallyAltered", "Mana", "Ranged", "Noxus", "2010" });
            champions.Add("Lee Sin", new List<string> { "Male", "Jungle", "Human Spiritualist", "Energy", "Melee", "Ionia", "2011" });
            champions.Add("Leona", new List<string> { "Female", "Support", "Aspect Human", "Mana", "Melee", "Targon", "2011" });
            champions.Add("Lilia", new List<string> { "Female", "Jungle Top", "Spirit", "Mana", "Melee", "Ionia", "2020" });
            champions.Add("Lissandra", new List<string> { "Female", "Mid", "Human Iceborn", "Mana", "Ranged", "Freljord", "2013" });
            champions.Add("Lucian", new List<string> { "Male", "Bot", "Human", "Mana", "Ranged", "Shadow Isles Runeterra Demacia", "2013" });//Added Runeterra to Region
            champions.Add("Lulu", new List<string> { "Female", "Support", "Yordle", "Mana", "Ranged", "BandleCity", "2012" });
            champions.Add("Lux", new List<string> { "Female", "Mid Support", "Human Magicborn", "Mana", "Ranged", "Demacia", "2010" });
            champions.Add("Malphite", new List<string> { "Male", "Mid Top", "Golem", "Mana", "Melee", "Ixtal Shurima", "2009" });//Added Mid to Positions
            champions.Add("Malzahar", new List<string> { "Male", "Mid", "Human Void-Being", "Mana", "Ranged", "Icathia Shurima Void", "2010" });
            champions.Add("Maokai", new List<string> { "Male", "Jungle Support Top", "Spirit", "Mana", "Melee", "ShadowIsles", "2011" });//Added Jungle to Positions
            champions.Add("Master Yi", new List<string> { "Male", "Jungle", "Human Spiritualist", "Mana", "Melee", "Ionia", "2009" });
            champions.Add("Miss Fortune", new List<string> { "Female", "Bot", "Human", "Mana", "Ranged", "Bilgewater", "2010" });
            champions.Add("Mordekaiser", new List<string> { "Male", "Jungle Top", "Revenant", "Shield", "Melee", "Noxus", "2010" });
            champions.Add("Morgana", new List<string> { "Female", "Support", "Aspect Human MagicallyAltered", "Mana", "Ranged", "Demacia Targon", "2009" });
            champions.Add("Nami", new List<string> { "Female", "Support", "Vastayan", "Mana", "Ranged", "Runeterra", "2012" });
            champions.Add("Nasus", new List<string> { "Male", "Top", "God-Warrior", "Mana", "Melee", "Shurima", "2009" });
            champions.Add("Nautilus", new List<string> { "Male", "Support", "Revenant", "Mana", "Melee", "Bilgewater", "2012" });
            champions.Add("Neeko", new List<string> { "Female", "Mid Support", "Vastayan", "Mana", "Ranged", "Ixtal", "2018" });
            champions.Add("Nidalee", new List<string> { "Female", "Jungle", "Human Spiritualist", "Mana", "Melee Ranged", "Ixtal", "2009" });
            champions.Add("Nilah", new List<string> { "Female", "Bot", "Human MagicallyAltered", "Mana", "Melee", "Bilgewater", "2022" });
            champions.Add("Nocturne", new List<string> { "Male", "Jungle", "Demon Spirit", "Mana", "Melee", "Runeterra", "2011" });
            champions.Add("Nunu & Willump", new List<string> { "Male", "Jungle", "Human Yeti", "Mana", "Melee", "Freljord", "2009" });
            champions.Add("Olaf", new List<string> { "Male", "Jungle Top", "Human Iceborn", "Mana", "Melee", "Freljord", "2010" });
            champions.Add("Orianna", new List<string> { "Female", "Mid", "Golem", "Mana", "Ranged", "Piltover", "2011" });
            champions.Add("Ornn", new List<string> { "Male", "Top", "God Spirit", "Mana", "Melee", "Freljord", "2017" });
            champions.Add("Pantheon", new List<string> { "Male", "Jungle Mid Support Top", "Aspect Human", "Mana", "Melee", "Targon", "2010" });//Added Top to Positions
            champions.Add("Poppy", new List<string> { "Female", "Jungle Top", "Yordle", "Mana", "Melee", "Demacia", "2010" });
            champions.Add("Pyke", new List<string> { "Male", "Support", "Revenant", "Mana", "Melee", "Bilgewater", "2018" });
            champions.Add("Qiyana", new List<string> { "Female", "Jungle Mid", "Human Magicborn", "Mana", "Melee", "Ixtal", "2019" });
            champions.Add("Quinn", new List<string> { "Female", "Top", "Human", "Mana", "Ranged", "Demacia", "2013" });
            champions.Add("Rakan", new List<string> { "Male", "Support", "Vastayan", "Mana", "Melee", "Ionia", "2017" });
            champions.Add("Rammus", new List<string> { "Male", "Jungle", "God-Warrior", "Mana", "Melee", "Shurima", "2009" });
            champions.Add("Rek'Sai", new List<string> { "Female", "Jungle", "Void-Being", "Rage", "Melee", "Shurima Void", "2014" });
            champions.Add("Rell", new List<string> { "Female", "Support", "Human MagicallyAltered Magicborn", "Mana", "Melee", "Noxus", "2020" });
            champions.Add("Renata Glac", new List<string> { "Female", "Support", "ChemicallyAltered Human", "Mana", "Ranged", "Zaun", "2022" });
            champions.Add("Renekton", new List<string> { "Male", "Top", "God-Warrior", "Fury", "Melee", "Shurima", "2011" });
            champions.Add("Rengar", new List<string> { "Male", "Jungle Top", "Vastayan", "Ferocity", "Melee", "Ixtal", "2012" });
            champions.Add("Riven", new List<string> { "Female", "Top", "Human", "Manaless", "Melee", "Ionia Noxus", "2011" });
            champions.Add("Rumble", new List<string> { "Male", "Mid Top", "Yordle", "Heat", "Melee", "BandleCity", "2011" });
            champions.Add("Ryze", new List<string> { "Male", "Mid Top", "Human MagicallyAltered", "Mana", "Ranged", "Runeterra", "2009" });
            champions.Add("Samira", new List<string> { "Female", "Bot", "Human", "Mana", "Ranged", "Noxus Shurima", "2020" });
            champions.Add("Sejuani", new List<string> { "Female", "Jungle Top", "Human Iceborn", "Mana", "Melee", "Freljord", "2012" });
            champions.Add("Senna", new List<string> { "Female", "Support", "Human Undead", "Mana", "Ranged", "ShadowIsles Runeterra", "2019" });//Added Runeterra to Region
            champions.Add("Seraphine", new List<string> { "Female", "Support Mid Bot", "Human Magicborn", "Mana", "Ranged", "Piltover Zaun", "2020" });//Added Mid and Support to Positions
            champions.Add("Sett", new List<string> { "Male", "Top", "Human Vastayan", "Grit", "Melee", "Ionia", "2020" });
            champions.Add("Shaco", new List<string> { "Male", "Jungle", "Spirit", "Mana", "Melee", "Runeterra", "2009" });
            champions.Add("Shen", new List<string> { "Male", "Top", "Human Spiritualist", "Energy", "Melee", "Ionia", "2010" });
            champions.Add("Shyvana", new List<string> { "Female", "Jungle", "Dragon MagicallyAltered", "Fury", "Melee", "Demacia", "2011" });
            champions.Add("Singed", new List<string> { "Male", "Mid Top", "ChemicallyAltered Human", "Mana", "Melee", "Piltover Zaun", "2009" });
            champions.Add("Sion", new List<string> { "Male", "Top", "Revenant", "Mana", "Melee", "Noxus", "2009" });
            champions.Add("Sivir", new List<string> { "Female", "Bot", "Human", "Mana", "Ranged", "Shurima", "2009" });
            champions.Add("Skarner", new List<string> { "Male", "Jungle", "Backern", "Mana", "Melee", "Shurima", "2011" });
            champions.Add("Sona", new List<string> { "Female", "Support", "Human Magicborn", "Mana", "Ranged", "Demacia Ionia", "2010" });
            champions.Add("Soraka", new List<string> { "Female", "Support", "Celestial", "Mana", "Ranged", "Ionia Targon", "2009" });
            champions.Add("Swain", new List<string> { "Male", "Support Mid Bot", "Human MagicallyAltered", "Mana", "Ranged", "Noxus", "2010" });
            champions.Add("Sylas", new List<string> { "Male", "Mid Jungle", "Human Magicborn", "Mana", "Melee", "Demacia", "2019" });//Added Jungle to Positions
            champions.Add("Syndra", new List<string> { "Female", "Mid", "Human Magicborn", "Mana", "Ranged", "Ionia", "2012" });
            champions.Add("Tahm Kench", new List<string> { "Male", "Support Top", "Demon Spirit", "Mana", "Melee", "Bilgewater Runeterra", "2015" });
            champions.Add("Taliyah", new List<string> { "Female", "Jungle Mid", "Human Magicborn", "Mana", "Ranged", "Shurima", "2016" });
            champions.Add("Talon", new List<string> { "Male", "Jungle Mid", "Human", "Mana", "Melee", "Noxus", "2011" });
            champions.Add("Taric", new List<string> { "Male", "Support", "Aspect Human", "Mana", "Melee", "Demacia Targon", "2009" });
            champions.Add("Teemo", new List<string> { "Male", "Top", "Yordle", "Mana", "Ranged", "BandleCity", "2009" });
            champions.Add("Thresh", new List<string> { "Male", "Support", "Undead", "Mana", "Ranged", "ShadowIsles", "2013" });
            champions.Add("Tristana", new List<string> { "Female", "Bot", "Yordle", "Mana", "Ranged", "BandleCity", "2009" });
            champions.Add("Tryndamere", new List<string> { "Male", "Top", "Human MagicallyAltered", "Fury", "Melee", "Freljord", "2009" });
            champions.Add("Trundle", new List<string> { "Male", "Jungle Top", "Iceborn Troll", "Mana", "Melee", "Freljord", "2010" });
            champions.Add("Twisted Fate", new List<string> { "Male", "Mid", "Human Magicborn", "Mana", "Ranged", "Bilgewater", "2009" });
            champions.Add("Twitch", new List<string> { "Male", "Bot", "ChemicallyAltered Rat", "Mana", "Ranged", "Zaun", "2009" });
            champions.Add("Udyr", new List<string> { "Male", "Jungle Top", "Human Spiritualist", "Mana", "Melee", "Freljord Ionia", "2009" });
            champions.Add("Urgot", new List<string> { "Male", "Top", "ChemicallyAltered Cyborg Human", "Mana", "Ranged", "Noxus Zaun", "2010" });
            champions.Add("Varus", new List<string> { "Male", "Bot Mid", "Darkin Human", "Mana", "Ranged", "Ionia Runeterra Shurima", "2012" });
            champions.Add("Vayne", new List<string> { "Female", "Bot Top", "Human", "Mana", "Ranged", "Demacia", "2011" });
            champions.Add("Veigar", new List<string> { "Male", "Mid", "Yordle", "Mana", "Ranged", "BandleCity Runeterra", "2009" });
            champions.Add("Vel'Koz", new List<string> { "Male", "Mid Support", "Void-Being", "Mana", "Ranged", "Void", "2014" });
            champions.Add("Vex", new List<string> { "Female", "Mid", "Yordle", "Mana", "Ranged", "BandleCity ShadowIsles", "2021" });
            champions.Add("Vi", new List<string> { "Female", "Jungle", "Human", "Mana", "Melee", "Piltover Zaun", "2012" });
            champions.Add("Viego", new List<string> { "Male", "Jungle", "Undead", "Manaless", "Melee", "Camavor ShadowIsles", "2021" });
            champions.Add("Viktor", new List<string> { "Male", "Mid", "Cyborg Human", "Mana", "Ranged", "Piltover Zaun", "2011" });
            champions.Add("Vladimir", new List<string> { "Male", "Mid", "Human MagicallyAltered", "Health", "Ranged", "Camavor Noxus ShadowIsles", "2010" });//Resource changed from "Bloodthirst" to "Health"
            champions.Add("Volibear", new List<string> { "Male", "Jungle Top", "God Spirit", "Mana", "Melee", "Freljord", "2011" });
            champions.Add("Warwick", new List<string> { "Male", "Jungle Top", "ChemicallyAltered Cyborg Human", "Mana", "Melee", "Zaun", "2009" });
            champions.Add("Xayah", new List<string> { "Female", "Bot", "Vastayan", "Mana", "Ranged", "Ionia", "2017" });
            champions.Add("Xerath", new List<string> { "Male", "Mid Support", "God-Warrior", "Mana", "Ranged", "Shurima", "2011" });
            champions.Add("Xin Zhao", new List<string> { "Male", "Jungle", "Human", "Mana", "Melee", "Demacia Ionia Noxus", "2010" });
            champions.Add("Yasuo", new List<string> { "Male", "Mid", "Human Magicborn", "Flow", "Melee", "Ionia", "2013" });
            champions.Add("Yone", new List<string> { "Male", "Mid Top", "Human MagicallyAltered", "Manaless", "Melee", "Ionia", "2020" });
            champions.Add("Yorick", new List<string> { "Male", "Top", "Human MagicallyAltered", "Mana", "Melee", "ShadowIsles", "2011" });
            champions.Add("Yuumi", new List<string> { "Female", "Support", "Cat MagicallyAltered", "Mana", "Ranged", "BandleCity", "2019" });
            champions.Add("Zac", new List<string> { "Male", "Jungle Top", "Golem", "Health", "Melee", "Zaun", "2013" });//Added Top to Positions
            champions.Add("Zed", new List<string> { "Male", "Jungle Mid", "Human MagicallyAltered", "Energy", "Melee", "Ionia", "2012" });//Added Jungle to Positions
            champions.Add("Zeri", new List<string> { "Female", "Bot", "Human Magicborn", "Mana", "Ranged", "Zaun", "2022" });
            champions.Add("Ziggs", new List<string> { "Male", "Bot Mid", "Yordle", "Mana", "Ranged", "Piltover Zaun", "2012" });
            champions.Add("Zilean", new List<string> { "Male", "Mid Support", "Human Magicborn", "Mana", "Ranged", "Icathia Runeterra Shurima", "2009" });//Added Mid to Positions
            champions.Add("Zoe", new List<string> { "Female", "Mid", "Aspect Human", "Mana", "Ranged", "Targon", "2017" });
            champions.Add("Zyra", new List<string> { "Female", "Support", "Unknown", "Mana", "Ranged", "Ixtal", "2012" });


            List<string> championsAll = champions.Keys.ToList();
            Random random = new Random();
            int right = random.Next(0, championsAll.Count);
            string rightInput = championsAll[right];
            //string rightInput = "Aatrox"; //if you want to set the right champion manually uncomment this row and comment the row above.Then change the champion in the "" to whichever one you like

            Dictionary<string, List<string>> championsPos = new Dictionary<string, List<string>>();
            foreach (KeyValuePair<string, List<string>> champion in champions)
            {

                championsPos.Add(champion.Key, champion.Value[1].Split(" ").ToList());

            }

            Dictionary<string, List<string>> championsSpec = new Dictionary<string, List<string>>();
            foreach (KeyValuePair<string, List<string>> champion in champions)
            {

                championsSpec.Add(champion.Key, champion.Value[2].Split(" ").ToList());

            }

            Dictionary<string, List<string>> championsReg = new Dictionary<string, List<string>>();
            foreach (KeyValuePair<string, List<string>> champion in champions)
            {

                championsReg.Add(champion.Key, champion.Value[5].Split(" ").ToList());

            }


            while (true)
            {
                if (input == "Give up")
                {
                    Console.WriteLine(rightInput);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(String.Join(" | ", champions[rightInput]));
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                while (true)
                {


                    if (champions.ContainsKey(input))
                    {
                        break;
                    }
                    else
                    {
                        input = Console.ReadLine();
                    }
                }

                if (champions[input][0] == champions[rightInput][0])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(champions[input][0]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(champions[input][0]);
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" | ");
                //---------------------------------------------------------------------------------------
                if (champions[input][1] == champions[rightInput][1])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(champions[input][1]);
                }
                foreach (string position in championsPos[input])
                {
                    if (championsPos[rightInput].Contains(position) && champions[input][1] != champions[rightInput][1])
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(String.Join(", ", championsPos[input]));
                        checker1++;
                        break;
                    }

                }
                if (champions[input][1] != champions[rightInput][1] && checker1 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(String.Join(", ", championsPos[input]));
                }
                checker1 = 0;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" | ");
                //---------------------------------------------------------------------------------------
                if (champions[input][2] == champions[rightInput][2])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(String.Join(", ", championsSpec[input]));
                }
                foreach (string species in championsSpec[input])
                {

                    if (championsSpec[rightInput].Contains(species) && champions[input][2] != champions[rightInput][2])
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(String.Join(", ", championsSpec[input]));
                        checker2++;
                        break;
                    }
                }
                if (champions[input][2] != champions[rightInput][2] && checker2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(String.Join(", ", championsSpec[input]));
                }
                checker2 = 0;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" | ");
                //-------------------------------------------------------------------------------------------
                if (champions[input][3] == champions[rightInput][3])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(champions[input][3]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(champions[input][3]);
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" | ");
                //---------------------------------------------------------------------------------------------
                if (champions[input][4] == champions[rightInput][4])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(champions[input][4]);
                }
                else if (champions[input][4] == "Melee Ranged")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(champions[input][4]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(champions[input][4]);
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" | ");
                //----------------------------------------------------------------------------------------------
                if (champions[input][5] == champions[rightInput][5])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(String.Join(", ", championsReg[input]));
                }
                foreach (string regions in championsReg[input])
                {

                    if (championsReg[rightInput].Contains(regions) && champions[input][5] != champions[rightInput][5])
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(String.Join(", ", championsReg[input]));
                        checker3++;
                        break;
                    }

                }
                if (champions[input][5] != champions[rightInput][5] && checker3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(String.Join(", ", championsReg[input]));
                }
                checker3 = 0;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" | ");
                //-----------------------------------------------------------------------------------
                if (int.Parse(champions[input][6]) < int.Parse(champions[rightInput][6]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(champions[input][6] + "↑");
                }
                else if (int.Parse(champions[input][6]) > int.Parse(champions[rightInput][6]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(champions[input][6] + "↓");
                }
                else if (int.Parse(champions[input][6]) == int.Parse(champions[rightInput][6]))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(champions[input][6]);
                }
                Console.ForegroundColor = ConsoleColor.White;
                //------------------------------------------------------------------------------------------
                if (input == rightInput)
                {
                    if (rightInput == "Kai'Sa") //since you found this section of the code, I'm going to explain what it is. Basically when you guess one of these champions there is going to be a special message. I offered every friend of mine that used the program to choose a champion and a special greeting to it. Most of the messages are in bulgarian, but I'll translate them for you below :)
                    {
                        Console.WriteLine("shti izqm beliq buz"); //I will eat you white ass
                    }
                    else if (rightInput == "Qiyana")
                    {
                        Console.WriteLine("Imash golqma pishka"); //You have a huge dick
                    }
                    else if (rightInput == "Kayn")
                    {
                        Console.WriteLine("Imash Daddy issues"); //You have daddy issues
                    }
                    else if (rightInput == "Nasus")
                    {
                        Console.WriteLine("Tujen si bratle"); //You are sad, my brother
                    }
                    else if (rightInput == "Fiora")
                    {
                        Console.WriteLine("I kvo kato nqmam priqteli, imam 650k points na fiora"); //And what if i don't have friends, I have 650k points on fiora(that greeting was mine btw)
                    }
                    else if (rightInput == "Hecarim")
                    {
                        Console.WriteLine("Fast as fuck boiiii"); 
                    }
                    else if (rightInput == "Evelynn")
                    {
                        Console.WriteLine("Alice: Smash geroi; eksfri: Revnuvam"); //Alice(my gf): Smash champion, XFree(my gamertag):I'm jelaous
                    }
                    else if (rightInput == "Lux")
                    {
                        Console.WriteLine("Nqkoi den shte otkradna na xfreeto gadjeto"); //I will steal XFree's girlfriend(this was written by another girl, dw about my girlfriend she is only mine xd)
                    }
                    else if (rightInput == "Leona")
                    {
                        Console.WriteLine("Perma cc");
                    }
                    else if (rightInput == "Katarina")
                    {
                        Console.WriteLine("s 2ta kraka v guza"); //Your 2 feet in your ass
                    }
                    else if (rightInput == "Volibear")
                    {
                        Console.WriteLine("Дразниш ме ще те банна от живота!"); //You are annoying me, i will ban you from life
                    }
                    else if (rightInput == "Jax")
                    {
                        Console.WriteLine("if u dont see me with shojin, you will never see me.");
                    }
                    else if (rightInput == "Zoe")
                    {
                        Console.WriteLine("Da mi se igrae? Na men ne mi se igrae,az sum Eva"); //Do i want to play? I don't want to, im Eva(she always grumbled: "I don't want to play anymoreeeeee", which was so funny, cuz she did it in a really pitch voice)
                    }
                    break;
                }
                input = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }

        }



    }
}


