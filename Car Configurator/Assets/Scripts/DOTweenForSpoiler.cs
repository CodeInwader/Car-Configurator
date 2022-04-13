using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOTweenForSpoiler : MonoBehaviour
{
    public Vector3 PosVector;
    public Transform spoilerPosTransform;

    public DOTweenInfo info;

   
    private void OnMouseDown()
    {


        if (info.isOnlastTransform == true)
        {
            info.isOnlastTransform = false;
            SetPositionToSpoiler();
        }

    }

    void SetPositionToSpoiler()
    {

        info.watchingParts = true;

        DOTweenInfo.lastCameraPosition = info.camera.transform.position;
        DOTweenInfo.lastCameraRotation = info.camera.transform.rotation.eulerAngles;

        PosVector = spoilerPosTransform.position;
        info.camera.transform.DOMove(PosVector, 1);

        PosVector = spoilerPosTransform.rotation.eulerAngles;
        info.camera.transform.DORotate(PosVector, 1);

        PosVector = spoilerPosTransform.position;
    }



    private void Update()
    {
        if(info.camera.transform.position == PosVector)
        {
            info.isOnlastTransform = false;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            info.watchingParts = false;

            info.camera.transform.DOMove(DOTweenInfo.lastCameraPosition, 1);

            info.camera.transform.DORotate(DOTweenInfo.lastCameraRotation, 1);

        }

    }

}
