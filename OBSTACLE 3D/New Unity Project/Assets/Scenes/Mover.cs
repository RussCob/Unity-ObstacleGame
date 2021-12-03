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
        
    }

    // Update is called once per frame
    void Update()
    {

        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical")   * Time.deltaTime * moveSpeed;

        transform.Translate(xValue,0,zValue);
        
    }
}
