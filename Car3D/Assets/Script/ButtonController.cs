using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{

    public void Acelerar()
    {
      
        CarController.Instance_CarController.acelerar = true;


    }

    public void Retroceder()
    {

    }


    public void  DoblarDerecha()
    {
        CarController.Instance_CarController.dob = 1;
    
    }

    public void DoblarIzquierda()
    {
        CarController.Instance_CarController.dob = -1;


    }



}
