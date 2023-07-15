using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Element : MonoBehaviour
{
    private string m_id;
    private string m_name;
    private string m_description;
    private Image m_icone;
    public Element(string _id, string _name, string _description, Image _icone)
    {
        m_id = _id;
        m_name = _name;
        m_description = _description;
        m_icone = _icone;
    }
}
