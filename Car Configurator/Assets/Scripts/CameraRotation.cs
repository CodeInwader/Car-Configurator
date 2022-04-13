using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private GameObject gg;

    float xRotation = 0f;

    Vector3 finalDestination;

    float angle;

    public Vector3 direction;

    Vector3 lastCameraPosition;

    float inetriaSpeed = 0;

    float topLimiter = -15.3f;
    float downLomiter = -13.96f;

    float downlimiterForgg = -10.5f;

    public DOTweenInfo info;

    Vector3 startPosition;

    private Vector3 previousPosition;
    // Update is called once per frame
    void Update()
    {

        //inhertia
       if (Input.GetMouseButtonDown(0) && !info.watchingParts)
        {
            previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);
        }

        if (  Input.GetMouseButton(0) &&  !info.watchingParts)
        {
           
            inetriaSpeed = 90;


            direction = previousPosition - cam.ScreenToViewportPoint(Input.mousePosition);
            
               cam.transform.position = new Vector3(-1.3f, -15f, -4f);

                cam.transform.Rotate(new Vector3(0, 1, 0), -direction.x * inetriaSpeed, Space.World);

            
            if ( direction.y < 0 && gg.transform.position.y  <= -15.9 || direction.y > 0 && gg.transform.position.y >= -15.3f)
            {
                inetriaSpeed = 0;
            }
           

                cam.transform.Rotate(new Vector3(1, 0, 0), direction.y * inetriaSpeed);
                cam.transform.Translate(0, 0, -5);

                previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);

            
        }

       

        if (inetriaSpeed > 0 && !info.watchingParts && cam.transform.position.y <= -13.96)
        {
                inetriaSpeed = 0;
        }

        if (inetriaSpeed > 0 && !info.watchingParts && gg.transform.position.y ! <= -10.5)
           {
            cam.transform.position = new Vector3(-1.3f, -15f, -4f);

            cam.transform.Rotate(new Vector3(1, 0, 0), direction.y * inetriaSpeed);
            cam.transform.Rotate(new Vector3(0, 1, 0), -direction.x * inetriaSpeed, Space.World);
            cam.transform.Translate(0, 0, -5);

            previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);

            inetriaSpeed = inetriaSpeed - 0.25f;
            

        }


       


      

        
      
      


    }
   


}
