using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;
    
    [SerializeField] private camerafollow cameraController;
    // Start is called before the first frame update
    void Start()
    {
        cameraController.InitCamera(playerCamera);
    }

    // Update is called once per frame
    void Update()
    {
        


    }
}
