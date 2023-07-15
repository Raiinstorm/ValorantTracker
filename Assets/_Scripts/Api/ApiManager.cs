using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using UnityEngine;
using System.Text;
using Newtonsoft.Json;

public class ApiManager : MonoBehaviour
{
    private string m_apiKey; 
    
    public ApiManager (string _apiKey)
    {
        m_apiKey = _apiKey;
    }

    public string GetDataFromAPI(string _baseUrl,string _language)
    {
        var parameters = new Dictionary<string, string>()
        {
            {"language",_language},
            {"api_key",m_apiKey}
        };
        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("APIKEYPARAM", m_apiKey);

            var baseUrl = _baseUrl;
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
    public ApiCharacterData DeserializeData(string jsonData)
    {
        return JsonUtility.FromJson<ApiCharacterData>(jsonData);
    }
}
