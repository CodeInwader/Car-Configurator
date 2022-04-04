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



[SerializeField]
public class ChangingParts : MonoBehaviour
{
    

    List<Colours> listOfColours = new List<Colours>();
   

    public List<GameObject> spoilers = new List<GameObject>();
    public List<GameObject> wheals = new List<GameObject>();
    public List<Material> colourList = new List<Material>();

   


    public GameObject car;

    public Colours colour;

    public GameObject BasicWheals;

    public int currentIndexForSpoilers;
    public int currentIndexForWheals;
    public int currentIndexForColour;

    private void Start()
    {
        wheals[3].SetActive(true);
        currentIndexForWheals = 3;
        currentIndexForSpoilers = -1;
        car.GetComponent<MeshRenderer>().material = colourList[0];
    }

    public void SetColour(int indexForColour)
    {
        car.GetComponent<MeshRenderer>().material = colourList[indexForColour];
        currentIndexForColour = indexForColour;
    }

    public void Loadconf(int indexForWheals, int indexForSpoiler, int indexForColour)
    {
        foreach (GameObject element in wheals)
        {
            if (element.activeInHierarchy == true)
            {
                element.SetActive(false);
            }
        }

        foreach (GameObject element in spoilers)
        {
            if (element.activeInHierarchy == true)
            {
                element.SetActive(false);
            }
        }

        wheals[indexForWheals].SetActive(true);
        spoilers[indexForSpoiler].SetActive(true);
        car.GetComponent<MeshRenderer>().material = colourList[indexForColour];

    }


    public void SetWheal(int indexForWheals)
    {
       
       

        foreach (GameObject element in wheals)
        {
            if(element.activeInHierarchy == true)
            {
                element.SetActive(false);
            }
        }

        wheals[indexForWheals].SetActive(true);
        currentIndexForWheals = indexForWheals;
        
    }

    public void SetSpoiler(int indexForSpoilers)
    {
        //saveData.indexForSpoilersToSave = indexForSpoilers;
        

        foreach (GameObject element in spoilers)
        {
            if(element.activeInHierarchy == true)
            {
                element.SetActive(false);
            }
        }

        
        spoilers[indexForSpoilers].SetActive(true);
        currentIndexForSpoilers = indexForSpoilers;
       
    }

}
