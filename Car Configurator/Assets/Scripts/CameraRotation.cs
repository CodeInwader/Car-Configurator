using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public GameObject target;
    float speed = 5f;
    public float minFOV = 35f;
    public float maxFOV = 100f;

    public DOTweenInfo info;

   

    [SerializeField]
    private GameObject camera;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Mouse0) && info.watchingParts == false)
        {
            transform.RotateAround(target.transform.position, transform.up, Input.GetAxis("Mouse X") * speed);
            
        }

     
       
    }
}
