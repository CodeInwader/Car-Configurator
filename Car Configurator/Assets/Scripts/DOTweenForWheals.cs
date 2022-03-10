using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOTweenForWheals : MonoBehaviour
{
    public Vector3 PosVector;
    public Vector3 lastCameraPosition;
    public Vector3 lastCameraRotation;
    public Transform whealPosTransform;
    
    public GameObject camera;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            camera.transform.DOMove(lastCameraPosition, 1);

            camera.transform.DORotate(lastCameraRotation, 1);
            
        }
    }

   

    private void OnMouseDown()
    {
      SetPositionToWheal();
    }

    void SetPositionToWheal()
    {
        lastCameraPosition = camera.transform.position;
        lastCameraRotation = camera.transform.rotation.eulerAngles;

        PosVector = whealPosTransform.position;
        camera.transform.DOMove(PosVector, 1);

        PosVector = whealPosTransform.rotation.eulerAngles;
        camera.transform.DORotate(PosVector, 1);
    }


   
}
