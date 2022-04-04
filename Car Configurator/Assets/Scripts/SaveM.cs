using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class Configuration
{
    public int indexForWhealsToSave;
    public int indexForSpoilersToSave;
    public int indexForColourToSave;
    public string nameOfConfiguration;
}




public class SaveM : MonoBehaviour
{

    public List<Configuration> allConf = new List<Configuration>();

    public ChangingParts changingparts;

    public Text textFrominputField;
    
    //Slots
    public Transform paretnOfSavesTransform;
    public GameObject slotPrefab;
    public List<GameObject> allslots = new List<GameObject>();
    int numOfSlots = 0;



    private void Awake()
    {
        LoadFromJson();
    }

    private void Start()
    {
        for (int i = 0; i < allConf.Count; i++)
        {
            GameObject currentslot = Instantiate(slotPrefab, paretnOfSavesTransform);
            Button button = currentslot.GetComponent<Button>();
            int temp = numOfSlots;
            button.onClick.AddListener(() => Load(temp));
            numOfSlots++;
        }
        
    }

    public void Save()
    {
        Configuration save = new Configuration();

        save.indexForSpoilersToSave = changingparts.currentIndexForSpoilers;
        save.indexForWhealsToSave = changingparts.currentIndexForWheals;
        save.indexForColourToSave = changingparts.currentIndexForColour;


        allConf.Add(save);

        SaveToJson(allConf);

        //Slots creating

        
        GameObject currentslot = Instantiate(slotPrefab, paretnOfSavesTransform);

        save.nameOfConfiguration = textFrominputField.text;
        
        currentslot.GetComponentInChildren<Text>().text = save.nameOfConfiguration;
       
        Button button = currentslot.GetComponent<Button>();
        int temp = numOfSlots;
        button.onClick.AddListener(() => Load(temp));
    }

    public void Load(int indexforconfig)
    {
        changingparts.Loadconf(allConf[indexforconfig].indexForWhealsToSave , allConf[indexforconfig].indexForSpoilersToSave, allConf[indexforconfig].indexForColourToSave);  
    }
   

    public void SaveToJson(List<Configuration> save)
    {
        string json = JsonConvert.SerializeObject(save);
        Debug.Log(json);
        File.WriteAllText(Application.persistentDataPath + "/save.json", json);

        
    }

   

    private void LoadFromJson()
    {
        if (!File.Exists(Application.persistentDataPath + "/save.json"))
        {
            Configuration save = new Configuration();
            save.indexForSpoilersToSave = 0;
            save.indexForWhealsToSave = 0;
            save.indexForColourToSave = 0;
            save.nameOfConfiguration = "No Name";

            allConf.Add(save);
            
            return;
        }


        string json;
        json = File.ReadAllText(Application.persistentDataPath + "/save.json");

        allConf = JsonConvert.DeserializeObject<List<Configuration>>(json);

        
    }
}
