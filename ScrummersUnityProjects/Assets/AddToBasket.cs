using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToBasket : MonoBehaviour
{
    private BasketItems basket;

    public void AddItem()
    {
        basket.items.Add(transform.parent.gameObject);

    }

    // Start is called before the first frame update
    void Start()
    {
        basket = GameObject.Find("Basket").GetComponent<BasketItems>();
    }
}
