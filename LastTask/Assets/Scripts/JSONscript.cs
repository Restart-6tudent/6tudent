using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.EventSystems;

public class NewBehaviourScript : MonoBehaviour
{ 
    public float number = 5.0f;
    public string jsonURL;
    public JSONclass jsonData, forChange;

    void Start()
    {
        StartCoroutine(getData());
    }

    IEnumerator getData()
    { 
        var uwr = new UnityWebRequest(jsonURL);
        uwr.method = UnityWebRequest.kHttpVerbGET;
        var resultFile = Path.Combine(Application.persistentDataPath, "myfile.json");
        var dh = new DownloadHandlerFile(resultFile);
        dh.removeFileOnAbort = true;
        uwr.downloadHandler = dh;
        yield return uwr.SendWebRequest(); // ?
        if (uwr.result != UnityWebRequest.Result.Success)
        {
            Debug.Log("Ошибка");
        }
        else
        {
            jsonData = JsonUtility.FromJson<JSONclass>(File.ReadAllText(Application.persistentDataPath + "/myfile.json"));
            this.transform.position = new Vector3(jsonData.x, jsonData.y, jsonData.z);
        }
    }

    void Update()
    {
        if (this.transform.position.y < number)
        {
            jsonData = JsonUtility.FromJson<JSONclass>(File.ReadAllText(Application.persistentDataPath + "/myfile.json"));
            forChange.x = this.transform.position.x;
            forChange.y = this.transform.position.y;
            forChange.z = this.transform.position.z;
            this.transform.position = new Vector3(jsonData.x, jsonData.y, jsonData.z);
            number--;
            jsonData = forChange;
            File.WriteAllText(Application.persistentDataPath + "/myfile.json", JsonUtility.ToJson(jsonData));
        }
    }
    
    [System.Serializable]
    public class JSONclass
    {
        public float x, y, z;
    }
}