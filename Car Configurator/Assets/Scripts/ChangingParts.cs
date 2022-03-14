using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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

    public GameObject BasicWheals;

   public static int indexForSpoilers = 0;
    public static int indexForWheals = 0;

   

    private void Start()
    {
        wheals[3].SetActive(true);
        colour = GetComponent<Colours>();

       
    }

    public void SetColour()
    {
        car.GetComponent<MeshRenderer>().material = colour.colour;
    }

    public void SetWheal()
    {
        foreach(GameObject element in wheals)
        {
            if(element.activeInHierarchy == true)
            {
                element.SetActive(false);
            }
        }

        wheals[indexForWheals].SetActive(true);
    }

    public void SetSpoiler()
    {
        

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
