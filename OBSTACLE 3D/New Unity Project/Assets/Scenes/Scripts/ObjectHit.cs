using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // Add Collison note on the console
    private void OnCollisionEnter(Collision other) 
    {
       
        //Change color
        GetComponent<MeshRenderer>().material.color = Color.red;
        
    }
}
