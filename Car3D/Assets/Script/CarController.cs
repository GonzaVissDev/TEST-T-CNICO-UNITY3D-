using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{
    private float moveInput;
   
    private float rlInput;
    public float dob =0;


    public bool acelerar = false;
    public bool left;
    public bool right;

    //Speed Car
    public float startSpeed;
    public float maxSpeed;
    

    public float rlSpeed;
    
    
    //Reverse car
 
    public float revSpeed;

    public Rigidbody saphereRB;

    public static CarController Instance_CarController { get; private set; }


    void Start()
    {
        Instance_CarController = this;
        saphereRB.transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        
        moveInput = Input.GetAxisRaw("Vertical");
        rlInput = Input.GetAxisRaw("Horizontal");

       //FALTa indicar cuando el jugador aprete el boton 
        
        if (startSpeed <= maxSpeed && acelerar == true)
        {
            
            startSpeed += 100f * Time.deltaTime;

        }

      
        //Speed
        moveInput *= moveInput > 0 ? startSpeed: revSpeed;

        transform.position = saphereRB.transform.position;

      
        float newRotation = dob * rlSpeed * Time.deltaTime ;
        transform.Rotate(0, newRotation, 0, Space.World) ;


    }

    private void FixedUpdate()
    {
        saphereRB.AddForce(transform.forward * startSpeed, ForceMode.Acceleration);
    }
}
