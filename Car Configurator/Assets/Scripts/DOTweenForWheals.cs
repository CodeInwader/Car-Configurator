using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.EventSystems;




public class DOTweenForWheals : MonoBehaviour
{
    public Vector3 PosVector;
    public Transform whealPosTransform;
   // public GameObject camera;

   
    public DOTweenInfo info;

    private void Start()
    {
        DOTweenInfo.lastCameraPosition = info.camera.transform.position;
        DOTweenInfo.lastCameraRotation = info.camera.transform.rotation.eulerAngles;

       

    }

    private void Update()
    {
        if (info.camera.transform.position == PosVector)
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

   

    private void OnMouseDown()
    {

        if (EventSystem.current.IsPointerOverGameObject()) return;
        if (info.isOnlastTransform == true)
        {
            info.isOnlastTransform = false;
            SetPositionToWheal();
        }
       
    }

    void SetPositionToWheal()
    {



        info.watchingParts = true;

        DOTweenInfo.lastCameraPosition = info.camera.transform.position;
        DOTweenInfo.lastCameraRotation = info.camera.transform.rotation.eulerAngles;

        PosVector = whealPosTransform.position;
        info.camera.transform.DOMove(PosVector, 1);

        PosVector = whealPosTransform.rotation.eulerAngles;
        info.camera.transform.DORotate(PosVector, 1);

        PosVector = whealPosTransform.position;
    }


   
}
