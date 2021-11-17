using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Auto") == 0)
        {
            Debug.Log("Mustang");

        }else if (PlayerPrefs.GetInt("Auto") == 1)
        {

            Debug.Log("FIAT");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
