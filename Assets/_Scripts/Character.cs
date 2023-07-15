using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Agent", menuName = "AgentCreation", order = 1)]
[SerializeField]
public class Character : ScriptableObject
{
    private string m_id;

    [SerializeField] private TextCharacter[] m_DesciptionIHM;
    private Dictionary<language, TextCharacter> m_description = new Dictionary<language, TextCharacter>();
    [SerializeField] private Element[] m_abilites;
    [SerializeField] private Element m_role;
    [SerializeField] private Image m_sprite;
    [SerializeField] private Image m_icone;

    public string ID { get { return m_id;} }
    public Element[] Abilities { get { return m_abilites; } }
    public Element Role { get { return m_role; } }
    public Image Sprite { get { return m_sprite; } }
    public Image Icone { get { return m_icone; } }

    public void SetIdFromApiData(string _id)
    {
        m_id = _id;
    }
    public string Name(language _language)
    {
        return m_description[_language].Name;
    }
    public string Biography(language _language)
    {
        return m_description[_language].Biography;
    }
}
