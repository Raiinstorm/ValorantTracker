using System;

[Serializable]
public class Agent
{
    public string uuid;
    public string displayName;
    public string description;
    public string developerName;
    public string characterTags;
    public string displayIcon;
    public string displayIconSmall;
    public string bustPortrait;
    public string fullPortrait;
    public string fullPortraitV2;
    public string killfeedPortrait;
    public string background;
    public string[] backgroundGradientColors;
    public string assetPath;
    public bool isFullPortraitRightFacing;
    public bool isPlayableCharacter;
    public bool isAvailableForTest;
    public bool isBaseContent;
    public Role role;
    public Abilitie[] abilities;
    public Voice voiceLine;
}
