using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class ApiDataStructure
{
    public string version;
    public ApiParameters[] characters;
    public ApiParameters[] maps;
    public ApiParameters[] chromas;
    public ApiParameters[] skins;
    public ApiParameters[] skinLevels;
    public ApiParameters[] equips;
    public ApiParameters[] gameModes;
    public ApiParameters[] sprays;
    public ApiParameters[] sprayLevels;
    public ApiParameters[] charms;
    public ApiParameters[] charLevels;
    public ApiParameters[] playerCards;
    public ApiParameters[] playerTitles;
    public ApiParameters[] acts;
    public ApiParameters[] ceremonies;
}
