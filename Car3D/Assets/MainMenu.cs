using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ChooseFiat()
    {
        PlayerPrefs.SetInt("Auto", 1);

    }

    public void ChooseMustang()
    {

        PlayerPrefs.SetInt("Auto", 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
