using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using UnityEngine;
using System.Text;
using Newtonsoft.Json;

public class ApiManager : MonoBehaviour
{
    [SerializeField] private string m_apiKey = null;
    private ApiDataStructure Datas;
    void Start()
    {
        //Debug.Log(GetDataFromAPI(m_apiKey));
        Datas = DeserializeData(GetDataFromAPI(m_apiKey));
        foreach (ApiParameters mcharacter in Datas.characters)
        {
            Debug.Log(mcharacter.name);
        }
    }

    public static string GetDataFromAPI(string apiKey)
    {
        var parameters = new Dictionary<string, string>()
        {
            {"locale","fr-FR"},
            {"api_key",apiKey}
        };
        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("APIKEYPARAM", apiKey);

            var baseUrl = " https://eu.api.riotgames.com/val/content/v1/contents";
            var url = baseUrl + "?" + string.Join("&", parameters.Select(x => string.Format("{0}={1}",x.Key,x.Value)));
            var task = client.GetAsync(url);

            if(!task.Result.IsSuccessStatusCode)
            {
                throw new Exception(task.Result.StatusCode.ToString());
            }

            var readTask = task.Result.Content.ReadAsStringAsync();
            return readTask.Result;
        }
    }
    public static ApiDataStructure DeserializeData(string jsonData)
    {
        return JsonUtility.FromJson<ApiDataStructure>(jsonData);
    }
    
}
