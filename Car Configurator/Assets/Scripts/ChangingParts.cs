using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



[System.Serializable]
public class Colours
{
    public string name;
    public Material colour;
}




public class ChangingParts : MonoBehaviour
{
    

    List<Colours> listOfColours = new List<Colours>();
   

    public List<GameObject> spoilers = new List<GameObject>();
    public List<GameObject> wheals = new List<GameObject>();

    public GameObject car;

    public Colours colour;

    public SaveData saveData;

    public SaveScript saveScript;

    public GameObject BasicWheals;

    public int currentIndexForSpoilers;
    public int currentIndexForWheals;

    private void Start()
    {
        wheals[3].SetActive(true);
        currentIndexForWheals = 3;
        currentIndexForSpoilers = 0;
    }

    public void SetColour()
    {
        car.GetComponent<MeshRenderer>().material = colour.colour;
    }

    public void SetWheal(int indexForWheals)
    {
       
        saveData.indexForWhealsToSave = indexForWheals;
        Debug.Log(indexForWheals);

        foreach (GameObject element in wheals)
        {
            if(element.activeInHierarchy == true)
            {
                element.SetActive(false);
            }
        }

        wheals[indexForWheals].SetActive(true);
    }

    public void SetSpoiler(int indexForSpoilers)
    {
        saveData.indexForSpoilersToSave = indexForSpoilers;
        

        foreach (GameObject element in spoilers)
        {
            if(element.activeInHierarchy == true)
            {
                element.SetActive(false);
            }
        }

        
        spoilers[indexForSpoilers].SetActive(true);

    }

}
