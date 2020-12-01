using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [Header("Camera Settings")]
    [SerializeField] private Camera playerCamera;
    [SerializeField] private camerafollow cameraController;

    [Header("Player Settings")]
    [SerializeField] private Transform playerObjectTransform;
    [SerializeField] private float playerSpeed;

     float yPos = 0 ;
    // Start is called before the first frame update
    void Start()
    {
        cameraController.InitCamera(playerCamera);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMovement();



    }



    void UpdateMovement(){

        float xPos = 0;
       

        yPos += 1;

        playerObjectTransform.position = new Vector3(0,yPos * playerSpeed * Time.deltaTime,0);

        if (Input.GetButton("Jump")){
            xPos += 1;
            playerObjectTransform.position += new Vector3(xPos * playerSpeed * Time.deltaTime,0,0);

        }

        

    }


}
