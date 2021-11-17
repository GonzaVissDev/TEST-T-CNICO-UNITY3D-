using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject mustnagCar;
    public GameObject fiatCar;
    // Start is called before the first frame update
   
    
    
    
    //Solo por esta ocacion voy a utilizar playerprefs.
    
    
    void Start()

    {
        if (PlayerPrefs.GetInt("Auto") == 0)
        {
            Instantiate(mustnagCar, new Vector3(0, 1, 0), Quaternion.identity);
            Debug.Log("Mustang");

        }else if (PlayerPrefs.GetInt("Auto") == 1)
        {
            Instantiate(fiatCar, new Vector3(0,1,0), Quaternion.identity);
            Debug.Log("FIAT");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
