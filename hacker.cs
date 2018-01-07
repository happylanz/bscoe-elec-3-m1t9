using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hacker : MonoBehaviour {

    // Use this for initialization
    string greetmoto = "Hello Hacker!";
    int toCompare;
    int level;
    Screen currentScreen;

    enum Screen { MainMenu, Password, Win};
    string[] pwdlvl1 = {"tanks","rifle","bomb","badge","medal"};
    string[] pwdlvl2 = {"ghosts","busters","spooky","scared","breezy"};
    string[] pwdlvl3 = { "chocolate", "sweetheart", "honeymoon", "beautiful", "elegancy" };

    void Start () {
        
        showMainMenu(greetmoto);
	}

    void showMainMenu(string greetmoto)
    {
        currentScreen = Screen.MainMenu;
        Terminal.WriteLine("M1T9");
        Terminal.WriteLine(greetmoto);
        Terminal.WriteLine("What would you like to hack?");
        Terminal.WriteLine("\nPress 1 to hack Army Files");
        Terminal.WriteLine("Press 2 to hack Ghostbusters Files");
        Terminal.WriteLine("Press 3 to hack Crush's Heart");
        Terminal.WriteLine("\nEnter your selection:");
        
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            Terminal.ClearScreen();
            showMainMenu(greetmoto);
        }
        else if (input == "007")
        {
            Terminal.WriteLine("Welcome Mr. James, James Bond!");
        }

        else if (currentScreen == Screen.MainMenu)
        {
            if (input == "1")
            {
                level = 1;
                StartGame();
            }
            else if (input == "2")
            {
                level = 2;
                StartGame();
            }
            else if (input == "3")
            {
                level = 3;
                StartGame();
            }
            else
            {
                Terminal.ClearScreen();
                Terminal.WriteLine("Please type a valid level");
            }
        }else if(currentScreen == Screen.Password)
        {
            if(level == 1)
            {
                if (input == pwdlvl1[toCompare])
                {
                    WinGame(level);
                }
                else
                {
                    StartGame();
                }
            }else if (level == 2)
            {
                if (input == pwdlvl2[toCompare])
                {
                    WinGame(level);
                }
                else
                {
                    StartGame();
                }
            }else if (level == 3)
            {
                if (input == pwdlvl3[toCompare])
                {
                    WinGame(level);
                }
                else
                {
                    StartGame();
                }
            }
        }
        else if(currentScreen == Screen.Win)
        {
            WinGame(level);
        }
       
    }
    void WinGame(int level)
    {
        Terminal.ClearScreen();
        currentScreen = Screen.Win;
        if (level == 1)
        {
            Terminal.WriteLine("¶▅c●▄███████||▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅▅||█ \n▄██ ▲  █ █ ██▅▄▃▂ \n███▲ ▲ █ █ ███████ \n███████████████████████► \n◥☼▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙☼◤");
        }
        else if (level == 2)
        {
            Terminal.WriteLine("┈┈┈┈╱▔▔▔▔▔▔╲┈╭━━━╮┈┈┈\n┈┈┈▕┈╭━╮╭━╮┈▏┃BOO…┃┈┈┈\n┈┈┈▕┈┃╭╯╰╮┃┈▏╰┳━━╯┈┈┈\n┈┈┈▕┈╰╯╭╮╰╯┈▏┈┃┈┈┈┈┈┈\n┈┈┈▕┈┈┈┃┃┈┈┈▏━╯┈┈┈┈┈┈\n┈┈┈▕┈┈┈╰╯┈┈┈▏┈┈┈┈┈┈┈┈\n┈┈┈▕╱╲╱╲╱╲╱╲▏┈┈┈┈┈┈┈┈");
        }
        else if (level == 3)
        {
            Terminal.WriteLine("▀██▀─▄███▄─▀██─██▀██▀▀█\n─██─███─███─██─██─██▄█\n─██─▀██▄██▀─▀█▄█▀─██▀█\n▄██▄▄█▀▀▀─────▀──▄██▄▄█");
        }
            Terminal.WriteLine(" ! ! C O N G R A T U L A T I O N S ! !");

    }

    void StartGame()
    {
        Terminal.ClearScreen();
        currentScreen = Screen.Password;
        toCompare = UnityEngine.Random.Range(0, 4);
        if (level == 1)
        {
            Terminal.WriteLine("Level " + level +": "+StringExtension.Anagram(pwdlvl1[toCompare]));

        }else if (level == 2)
        {
            Terminal.WriteLine("Level " + level + ": " + StringExtension.Anagram(pwdlvl2[toCompare]));
        }
        else if (level == 3)
        {
            Terminal.WriteLine("Level " + level + ": " + StringExtension.Anagram(pwdlvl3[toCompare]));
        }
        Terminal.WriteLine("Enter Password: ");
    }



    // Update is called once per frame
    void Update () {
		
	}
}
