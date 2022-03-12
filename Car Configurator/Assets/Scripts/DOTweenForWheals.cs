using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;




public class DOTweenForWheals : MonoBehaviour
{
    public Vector3 PosVector;
    public Transform whealPosTransform;
    public GameObject camera;

    public DOTweenInfo info;

    private void Start()
    {
        DOTweenInfo.lastCameraPosition = camera.transform.position;
        DOTweenInfo.lastCameraRotation = camera.transform.rotation.eulerAngles;

       

    }

    private void Update()
    {
        if (camera.transform.position == PosVector)
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

   

    private void OnMouseDown()
    {
        

        if (info.isOnlastTransform == true)
        {
            info.isOnlastTransform = false;
            SetPositionToWheal();
        }
       
    }

    void SetPositionToWheal()
    {



        info.watchingParts = true;

        DOTweenInfo.lastCameraPosition = camera.transform.position;
        DOTweenInfo.lastCameraRotation = camera.transform.rotation.eulerAngles;

        PosVector = whealPosTransform.position;
        camera.transform.DOMove(PosVector, 1);

        PosVector = whealPosTransform.rotation.eulerAngles;
        camera.transform.DORotate(PosVector, 1);

        PosVector = whealPosTransform.position;
    }


   
}
