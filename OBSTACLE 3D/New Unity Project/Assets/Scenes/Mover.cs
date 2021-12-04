using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    //these variables change our movement speed
    //[SerializeField] float yValue = 0.02f;
    

    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        // call method
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        //
        MovePlayer();
        
    }

    // create new method
    void PrintInstruction ()
    {
        Debug.Log("Welcome to the game");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical")   * Time.deltaTime * moveSpeed;

        transform.Translate(xValue,0,zValue);
    }

}
