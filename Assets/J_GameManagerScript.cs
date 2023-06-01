using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class J_GameManagerScript : MonoBehaviour
{
    public static J_GameManagerScript Instance;
    public int thisScore;

    class SavePlayerData
    {
        public int SD_score;
    }

    public void SaveDate()
    {
        SavePlayerData data = new SavePlayerData();
        data.SD_score = thisScore;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savedatafile.json", json);
    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/savedatafile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SavePlayerData data = JsonUtility.FromJson<SavePlayerData>(json);
            thisScore = data.SD_score;
        }
    }
}


