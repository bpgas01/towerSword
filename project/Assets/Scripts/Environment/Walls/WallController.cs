using System.Runtime.ExceptionServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : playerEnvironment
{
    [SerializeField] private float friction;
    


    WallController(){
        objectName = "Wall";
        
    }    

    public void playerActive(){
        inUse = true;
    }

    public void playerInactive(){
        inUse = false;
    }

    public float getFriction(){
        return friction;
    }

}
