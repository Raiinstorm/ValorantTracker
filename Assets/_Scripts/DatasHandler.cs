using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatasHandler : MonoBehaviour
{
    [Header("Global parameters")]
    [SerializeField] private string m_apiKey;
    [SerializeField] private ApiLanguage m_language;

    private ApiManager m_apiManager;
    private ApiCharacterData m_agentsDatas;
    private void Start()
    {
        m_apiManager = new ApiManager(m_apiKey);
        string language = m_language.ToString();
        m_agentsDatas = m_apiManager.DeserializeData(m_apiManager.GetDataFromAPI("https://valorant-api.com/v1/agents/", language.Substring(0,2) + "-" + language.Substring(2)));
    
        foreach(Agent mAgent in m_agentsDatas.data)
        {
            Debug.Log(mAgent.displayName + " " + mAgent.description);
        }
    }
}
