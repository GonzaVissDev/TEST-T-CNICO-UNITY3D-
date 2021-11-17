using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ChooseFiat()
    {
        PlayerPrefs.SetInt("Auto", 1);
        SceneManager.LoadScene(1);
    }

    public void ChooseMustang()
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("Auto", 0);

    }

 
}
