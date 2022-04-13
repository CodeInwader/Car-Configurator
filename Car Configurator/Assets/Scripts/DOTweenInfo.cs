using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOTweenInfo : MonoBehaviour
{
    public static Vector3 lastCameraPosition;
    public static Vector3 lastCameraRotation;

    
    public GameObject camera;

    public  bool watchingParts = false;
    public  bool isOnlastTransform = true;



    private void Update()
    {
          if (camera.transform.position == lastCameraPosition  && camera.transform.rotation.eulerAngles == lastCameraRotation)
          {
             isOnlastTransform = true;
          }


    }
}
