using UnityEngine;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine.UI;
using System.Xml;


public class WebDataFetcher : MonoBehaviour
{
    public string url;
    public Text listItemPrefab;
    public Transform contentTransform;

    private async void Start()
    {
        string xmlData = await FetchXmlDataFromUrl(url);
        List<string> parsedData = ParseXmlData(xmlData);
        PopulateList(parsedData);
        ScaleListToScreen();
    }
    
    private async Task<string> FetchXmlDataFromUrl(string url)
    {
        using (WebClient client = new WebClient())
        {
            return await client.DownloadStringTaskAsync(url);
        }
    }

    private List<string> ParseXmlData(string xmlData)
    {
        
    }
}