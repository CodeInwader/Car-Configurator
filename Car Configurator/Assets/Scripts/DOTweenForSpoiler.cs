using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOTweenForSpoiler : MonoBehaviour
{
    public Vector3 PosVector;
    public Vector3 lastCameraPosition;
    public Vector3 lastCameraRotation;
    public Transform spoilerPosTransform;

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
        SetPositionToSpoiler();
    }

    void SetPositionToSpoiler()
    {
        lastCameraPosition = camera.transform.position;
        lastCameraRotation = camera.transform.rotation.eulerAngles;

        PosVector = spoilerPosTransform.position;
        camera.transform.DOMove(PosVector, 1);

        PosVector = camera.transform.rotation.eulerAngles;
        camera.transform.DORotate(PosVector, 1);
    }
}
