using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;
using UnityEngine.UI;

[System.Serializable]
public class Configuration
{
    public int indexForWhealsToSave;
    public int indexForSpoilersToSave;

    public string nameOfConfiguration;
}




public class SaveM : MonoBehaviour
{

    public List<Configuration> allConf = new List<Configuration>();

    public ChangingParts changingparts;

    public InputField inputfield;
    //Slots
    public Transform paretnOfSavesTransform;
    public GameObject slotPrefab;
    public List<GameObject> allslots = new List<GameObject>();
    int numOfSlots = 0;



    private void Awake()
    {
        LoadFromJson();
    }

    public void Save()
    {
        Configuration save = new Configuration();

        save.indexForSpoilersToSave = changingparts.currentIndexForSpoilers;
        save.indexForWhealsToSave = changingparts.currentIndexForWheals;
       
        allConf.Add(save);

        SaveToJson(allConf);

        //Slots creating
        

        GameObject currentslot = Instantiate(slotPrefab, paretnOfSavesTransform);   
        Button button = currentslot.GetComponent<Button>();
        button.GetComponentInChildren<Text>().text = inputfield.text;
        int temp = numOfSlots;
        button.onClick.AddListener(() => Load(temp));
    }

    public void Load(int indexforconfig)
    {
        changingparts.Loadconf(allConf[indexforconfig].indexForWhealsToSave , allConf[indexforconfig].indexForSpoilersToSave);  
    }
   

    public void SaveToJson(List<Configuration> save)
    {
        string json = JsonConvert.SerializeObject(save);
        Debug.Log(json);
        File.WriteAllText(Application.persistentDataPath + "/save.json", json);

        
    }

    private void Update()
    {
        //Slots creating from save file
        if (numOfSlots != allConf.Count)
        {
            GameObject currentslot = Instantiate(slotPrefab, paretnOfSavesTransform);
            Button button = currentslot.GetComponent<Button>();
            int temp = numOfSlots;
            button.onClick.AddListener(() => Load(temp));

            numOfSlots++;

        }
    }

    private void LoadFromJson()
    {
        if (!File.Exists(Application.persistentDataPath + "/save.json"))
        {
            Configuration save = new Configuration();
            save.indexForSpoilersToSave = 0;
            save.indexForWhealsToSave = 0;


            allConf.Add(save);
            
            return;
        }


        string json;
        json = File.ReadAllText(Application.persistentDataPath + "/save.json");

        allConf = JsonConvert.DeserializeObject<List<Configuration>>(json);

        
       
        
       
       

    }
}
