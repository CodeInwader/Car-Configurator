using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData : MonoBehaviour
{
    public int indexForWhealsToSave;
    public int indexForSpoilersToSave;


    void SaveData1(int indexForWheals ,int indexForSpoilers)
    {
        indexForWheals = indexForWhealsToSave;
        indexForSpoilers = indexForSpoilersToSave;
    }

    void SaveData2(int indexForWheals, int indexForSpoilers)
    {
        indexForWheals = indexForWhealsToSave;
        indexForSpoilers = indexForSpoilersToSave;
    }

    void SaveData3(int indexForWheals, int indexForSpoilers)
    {
        indexForWheals = indexForWhealsToSave;
        indexForSpoilers = indexForSpoilersToSave;
    }
}
