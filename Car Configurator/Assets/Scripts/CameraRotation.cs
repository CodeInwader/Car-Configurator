using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField] private Camera cam;

    Vector3 finalDestination;

    float angle;

    public Vector3 direction;

    float inetriaSpeed = 0;

    public DOTweenInfo info;

    Vector3 startPosition;

    private Vector3 previousPosition;
    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);
        }

        if (  Input.GetMouseButton(0) &&  !info.watchingParts  /*cam.transform.position.y < -10.5*/ )
        {
             direction = previousPosition - cam.ScreenToViewportPoint(Input.mousePosition);

            cam.transform.position = new Vector3(-1.3f, -15f, -4f);

            cam.transform.Rotate(new Vector3(1, 0, 0), direction.y * 90);
            cam.transform.Rotate(new Vector3(0,1,0),  -direction.x * 90, Space.World);
            cam.transform.Translate(0, 0, -5);


            previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);

            
            inetriaSpeed = 90;


        }
       
        
           if (inetriaSpeed > 0  /*cam.transform.position.y < -10.5*/)
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
