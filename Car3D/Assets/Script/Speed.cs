using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speed : MonoBehaviour
{
    public Text actext;
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        string speedtest = CarController.Instance_CarController.startSpeed.ToString("0 km");
        actext.text = ("Speed:" + speedtest);
    }
}
