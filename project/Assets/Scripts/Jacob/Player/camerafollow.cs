using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    [SerializeField] private Transform followObject;
    [SerializeField] private Vector3 offset;

    private Vector3 newPosition = new Vector3();
   
    private Camera main_camera;

    
    public void InitCamera(Camera camera){
        main_camera = camera;
    }

    // Update is called once per frame
    private void Update()
    {
        
        newPosition.x = 0;
        newPosition.z = offset.z;
        newPosition.y = followObject.position.y;

        main_camera.gameObject.transform.position = newPosition;
    }
    
        
    
}
