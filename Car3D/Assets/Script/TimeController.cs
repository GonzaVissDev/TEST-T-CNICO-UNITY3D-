using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    public Text timeText;

    public float startTime = 0.0f;



    private void Update()
    {
      float TimeInScene = startTime + Time.timeSinceLevelLoad;

        string minutes = ((int)TimeInScene / 60).ToString("Min");
        string seconds = (TimeInScene % 60).ToString("0 seg");

        timeText.text = ("TIEMPO:" + " "  +" " + minutes +  " " + seconds);
      


    }


   


}
