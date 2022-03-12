using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOTweenForSpoiler : MonoBehaviour
{
    public Vector3 PosVector;
    public Transform spoilerPosTransform;

    public DOTweenInfo info;

    public GameObject camera;



    private void OnMouseDown()
    {


        if (info.isOnlastTransform != false)
        {
            SetPositionToSpoiler();
        }

    }

    void SetPositionToSpoiler()
    {


        info.isOnlastTransform = false;

        info.watchingParts = true;

        DOTweenInfo.lastCameraPosition = camera.transform.position;
        DOTweenInfo.lastCameraRotation = camera.transform.rotation.eulerAngles;

        PosVector = spoilerPosTransform.position;
        camera.transform.DOMove(PosVector, 1);

        PosVector = spoilerPosTransform.rotation.eulerAngles;
        camera.transform.DORotate(PosVector, 1);

        PosVector = spoilerPosTransform.position;
    }



    private void Update()
    {
        if(camera.transform.position == PosVector)
        {
            info.isOnlastTransform = false;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            info.watchingParts = false;

            camera.transform.DOMove(DOTweenInfo.lastCameraPosition, 1);

            camera.transform.DORotate(DOTweenInfo.lastCameraRotation, 1);

        }

    }

}
