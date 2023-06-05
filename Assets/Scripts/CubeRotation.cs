using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    
    public float rotationSpeed;
    public Transform model;

    

    //private Vector3 prevPos = Vector3.zero;
    //private Vector3 posDelta = Vector3.zero;

    float rotX;

    //void OnMouseDrag()
    //{
    //    Debug.Log("IN");
    //    float rotX = Input.GetAxis("Mouse X") * rotationSpeed;
    //    //float rotY = Input.GetAxis("Mouse Y") * rotationSpeed ;


    //    transform.Rotate(Vector3.down * rotX);

    //    Debug.Log("here");


    //}

    private void Update()
    {
       
        if (Input.GetMouseButton(0))
        {
            rotX -= Input.GetAxis("Mouse X") * rotationSpeed;

            model.rotation = Quaternion.Euler(0, rotX, 0);
        }
    }

}
