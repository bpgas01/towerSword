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


    private Vector2 velocity;
    private Vector2 acceleration;
    private Vector2 displacement;


    private Vector2 playerForce;

     float yPos = 0 ;
    // Start is called before the first frame update
    void Start()
    {
        cameraController.InitCamera(playerCamera);
        

    }

    // Update is called once per frame
    void Update()
    {
    
        Collider[] hitColliders = Physics.OverlapSphere(playerObjectTransform.position, detectionRadius);

        foreach(var col in hitColliders){
            if (col.gameObject.CompareTag("Wall")){
                Debug.Log("On wall");
            }
        }


    }


}
