using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dynamic : MonoBehaviour
{

    public GameObject spoierButton;
    public GameObject whealsButton;
    public GameObject spoilersButtonParent;
    public GameObject whealsButtonParent;

    public ChangingParts changingParts;

    int indexForSpoilers = 1;
    int indexForWheals = 1;

    int numberOfSpoilers = 7;
    int numberOfWheals = 4;


    public List<GameObject> spoilersButtonList = new List<GameObject>();
   public List<GameObject> whealsButtonList = new List<GameObject>();
   public List<Sprite> spoilersImageList = new List<Sprite>();
   public  List<Sprite> whealsimageList = new List<Sprite>();

     GameObject createdGOButton;
   


    // Start is called before the first frame update
    void Start()
    {
       
        //Spoilers
        for (int i = 0; i < numberOfSpoilers; i++)
        {

           createdGOButton = Instantiate(spoierButton, spoilersButtonParent.transform);
          
            spoilersButtonList.Add(createdGOButton);
            
        }


        //Wheals
       
        for (int i = 0; i < numberOfWheals; i++)
        {
           
            createdGOButton = Instantiate(whealsButton, whealsButtonParent.transform);

            whealsButtonList.Add(createdGOButton);
        }

      
        foreach (GameObject element in spoilersButtonList)
        {
           ChangingParts changingPartsGet = element.GetComponent<ChangingParts>();

           indexForSpoilers++;
            Button button = element.GetComponent<Button>();
            button.onClick.AddListener(() => changingParts.SetSpoiler(indexForSpoilers, spoilersImageList[indexForSpoilers]));
            
            //changingPartsGet.SetSpoiler(indexForSpoilers, spoilersImageList[indexForSpoilers]);
            
        }

        
        foreach (GameObject element in whealsButtonList)
        {
            ChangingParts changingPartsGet = element.GetComponent<ChangingParts>();

            
            indexForWheals++;
            Button button = element.GetComponent<Button>();
            
            button.onClick.AddListener(() => changingParts.SetWheal(indexForWheals, whealsimageList[indexForWheals]));
           //changingPartsGet.SetWheal(indexForWheals, whealsimageList[indexForWheals]);
        }
    }





   
}
