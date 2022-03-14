
using UnityEngine;
using System.IO;

public static class saveManager
{
    public static string directory = "/SaveData/";
    public static string fileName = "MyData.txt";

    public static void Save(SaveData saveData)
    {
        string dir = Application.dataPath + directory;

        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        string json = JsonUtility.ToJson(saveData);
        File.WriteAllText(dir + fileName, json);
                
    }



    public static SaveData Load()
    {
        string fullPath = Application.persistentDataPath + directory + fileName;
        SaveData saveData = new SaveData();

        if (File.Exists(fullPath))
        {
            string json = File.ReadAllText(fullPath);
            saveData = JsonUtility.FromJson<SaveData>(json);
        }
        else
        {
            Debug.Log("save file does not exist");
        }

        return saveData;
    }

}

   

