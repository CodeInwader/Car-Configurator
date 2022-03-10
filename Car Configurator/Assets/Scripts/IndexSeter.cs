using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndexSeter : MonoBehaviour
{
    

    public int indexSetForSpoilers;
    public int indexSetForWheals;
    public ChangingParts changingParts = new ChangingParts();

   public void SetIndexForSpoilers()
    {
        ChangingParts.indexForSpoilers = indexSetForSpoilers;
        changingParts.SetSpoiler();
    }

    public void SetIndexForWheals()
    {
        ChangingParts.indexForWheals = indexSetForWheals;
        changingParts.SetWheal();
    }

    
}
