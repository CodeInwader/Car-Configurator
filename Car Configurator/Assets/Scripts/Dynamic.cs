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

    int indexForSpoilers = -1;
    int indexForWheals = -1;

   

    public List<GameObject> spoilersButtonList = new List<GameObject>();
   public List<GameObject> whealsButtonList = new List<GameObject>();
   public List<Sprite> spoilersImageList = new List<Sprite>();
   public  List<Sprite> whealsimageList = new List<Sprite>();

     GameObject createdGOButton;
   


    // Start is called before the first frame update
    void Start()
    {
       
        //Spoilers
        for (int i = 0; i < spoilersImageList.Count; i++)
        {

           createdGOButton = Instantiate(spoierButton, spoilersButtonParent.transform);
          
            spoilersButtonList.Add(createdGOButton);
            
        }


        //Wheals
       
        for (int i = 0; i < whealsimageList.Count; i++)
        {
           
            createdGOButton = Instantiate(whealsButton, whealsButtonParent.transform);

            whealsButtonList.Add(createdGOButton);
        }

      
        foreach (GameObject element in spoilersButtonList)
        {
           ChangingParts changingPartsGet = element.GetComponent<ChangingParts>();
            
            indexForSpoilers++;
            int temp = indexForSpoilers;
            Button button = element.GetComponent<Button>();
            button.onClick.AddListener(() => changingParts.SetSpoiler(temp));

            button.image.sprite = spoilersImageList[temp];

        }

        
        foreach (GameObject element in whealsButtonList)
        {
            ChangingParts changingPartsGet = element.GetComponent<ChangingParts>();
            indexForWheals++;
            int temp = indexForWheals;
            Button button = element.GetComponent<Button>();

            button.image.sprite = whealsimageList[temp];
            
            button.onClick.AddListener(() => changingParts.SetWheal(temp));
        }
    }

   
}
