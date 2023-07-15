using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class TextCharacter 
{
    [SerializeField] private language m_language;
    [SerializeField] private string m_name;
    [SerializeField] private string m_biography;

    public language Language { get { return m_language; } }
    public string Name { get { return m_name; } }
    public string Biography { get { return m_biography; } }
}
