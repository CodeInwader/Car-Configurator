using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsScript : MonoBehaviour
{
    [SerializeField] GameObject SaveMenuPanel;
    public DOTweenInfo info;

    public void OpenSaveMenuPanel()
    {

        SaveMenuPanel.SetActive(true);
        info.watchingParts = true;
    }

    public void ClodeSaveMenuPanel()
    {
        SaveMenuPanel.SetActive(false);
        info.watchingParts = false;
    }
}
