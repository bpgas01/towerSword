using System.Diagnostics;
using System.Xml.Schema;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [Header("Camera Settings")]
    [SerializeField] private Camera playerCamera;
    [SerializeField] private camerafollow cameraController;

    [Header("Player Settings")]
    [SerializeField] private Rigidbody rigidbodyComponent;
    [SerializeField] private Transform playerObjectTransform;
    [SerializeField] private float playerSpeed;

    [SerializeField] private float detectionRadius;
    [SerializeField] private float timerSlowMultiplier;


    private Vector3 velocity;
    private Vector3 acceleration;
    private Vector3 displacement;

    private bool toggleJump = false;
    private Vector3 playerForce;

     float yPos = 0 ;
    // Start is called before the first frame update
    void Start()
    {
        cameraController.InitCamera(playerCamera);
         

    }

    void toggle(){

        if (toggleJump == false){
            toggleJump = true;
            return;
        }
        if (toggleJump == true){
            toggleJump = false;
            return;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
       

        if (Input.GetButtonUp("Jump")){

            toggle();

            if (toggleJump == true){
                rigidbodyComponent.velocity = (transform.right * playerSpeed);
                
                // TO DO : Move right at specfic angle based on velocity (if on left wall)

            }
            else{
                rigidbodyComponent.velocity = -transform.right * playerSpeed;

                 // TO DO : Move left at specfic angle based on velocity (if on right wall)

            }

        }   
        

       yPos =0;


    }


}
