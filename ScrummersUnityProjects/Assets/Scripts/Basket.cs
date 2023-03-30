using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    public GameObject basketUI;
    public bool UIisUP = false;


    public void BasketClick()
    {
        UIisUP = !UIisUP;
        basketUI.SetActive(UIisUP);
    }
    
    
    //void OpenBasket()
    //{
    //        basketUI.SetActive(true);
    //        UIisUP = true;
    //}

    
    public void CloseBasket()
    {
            basketUI.SetActive(false);
            UIisUP = false;
    }
}
