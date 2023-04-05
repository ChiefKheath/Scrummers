using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class UiManager : MonoBehaviour
{
    public GameObject MainMenu, SimOnly100gb;
    
    
    // Start is called before the first frame update
    void Start()
    {
        SimOnly100gb.SetActive(false);
    }

    public void SimOnly100gbEnabled()
    {
        MainMenu.SetActive(false);
        SimOnly100gb.SetActive(true);
    }

    public void MainMenuEnable()
    {
        SimOnly100gb.SetActive(false);
        MainMenu.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
