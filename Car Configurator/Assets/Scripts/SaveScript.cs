using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SaveScript : MonoBehaviour
{

    public SaveData saveData;
    public ChangingParts changingParts;

   public List<GameObject> listOfSaveSlots = new List<GameObject>();


    private void Start()
    {
        foreach (GameObject element in listOfSaveSlots)
        {
            SlotsData s = element.GetComponent<SlotsData>();

            if (s.slotIsFull)
            {
                Button button = element.GetComponent<Button>();
                button.onClick.AddListener(() => LoadSave());
            }
        }
    }

    public void Save()
    {
        saveManager.Save(saveData);

        foreach (GameObject element in listOfSaveSlots)
        {
            SlotsData s = element.GetComponent<SlotsData>();

            if (!s.slotIsFull)
            {
                s.slotIsFull = true;
                Button button = element.GetComponent<Button>();
                button.onClick.AddListener(() => LoadSave());
                break;
            }
        }
    }


    public void LoadSave()
    {
        saveData = saveManager.Load();
    }
}
