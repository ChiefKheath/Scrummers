using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AddToBasket : MonoBehaviour
{
    private BasketItems basketItems;
    private Basket basket;

    public void AddItem()
    {
        basketItems.items.Add(transform.parent.gameObject);
        basket.basketButton.GetComponent<Image>().color = Color.black;
        basket.basketButtonTxt.text = "Basket (" + basketItems.items.Count.ToString() + ")";
    }

    // Start is called before the first frame update
    void Start()
    {
        basketItems = GameObject.Find("Basket").GetComponent<BasketItems>();
        basket = GameObject.Find("Manager").GetComponent<Basket>();
    }
}
