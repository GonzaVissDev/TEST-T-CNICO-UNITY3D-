using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{
    private float moveInput;
    private float rlInput;



    //Adelante
    public float fwdSpeed;
    

    public float rlSpeed;
    //Reversa
 
    public float revSpeed;

    public Rigidbody saphereRB;

    void Start()
    {
        saphereRB.transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        
        moveInput = Input.GetAxisRaw("Vertical");
        rlInput = Input.GetAxisRaw("Horizontal");

      
        //Speed
        moveInput *= moveInput > 0 ? fwdSpeed : revSpeed;

        transform.position = saphereRB.transform.position;

        //Rotation

        float newRotation = rlInput * rlSpeed * Time.deltaTime * Input.GetAxisRaw("Vertical");
        transform.Rotate(0, newRotation, 0, Space.World);

    }

    private void FixedUpdate()
    {
        saphereRB.AddForce(transform.forward * moveInput, ForceMode.Acceleration);
    }
}
