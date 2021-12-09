using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    //add variable for point
    int hits = 0;


    // Add score
    private void OnCollisionEnter(Collision other) 
    {
        // add more hits
        hits = hits + 1;
        //print to console
        Debug.Log("You bumped into this thing so many times  " + hits);  
       
        
    }
}
