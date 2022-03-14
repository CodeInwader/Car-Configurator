using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
class ListOfSlots
{
    public ChangingParts changingParts;
}

public class SaveScript : MonoBehaviour
{

    List<ListOfSlots> listOfSlots = new List<ListOfSlots>();
   

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void WantToSave()
    {
        /*
        foreach (GameObject element in listOfSlots)
        {
            if (element.)
            {

            }
        }
        */
    }

    public void Save()
    {
        SaveData.indexForWheals = ChangingParts.indexForWheals;
        SaveData.indexForSpoilers = ChangingParts.indexForSpoilers;
    }


    public void LoadSave()
    {
        ChangingParts.indexForSpoilers = SaveData.indexForSpoilers;
        ChangingParts.indexForWheals = SaveData.indexForWheals;

       // listOfSlots.SetSpoiler();
       // changingParts.SetWheal();
    }
}
