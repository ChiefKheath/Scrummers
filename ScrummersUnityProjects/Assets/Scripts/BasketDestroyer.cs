using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketDestroyer : MonoBehaviour
{
    public GameObject basketItem;
    private Basket basket;
    private int index;

    private void Start()
    {
        basket = GameObject.Find("Manager").GetComponent<Basket>();
    }

    public void Destroyer()
    {
        foreach (Transform child in gameObject.transform.parent.transform)
        {
            index++;
            if (child == gameObject.transform)
            {
                basket.basketItems.items.RemoveAt(index-1);
            }
        }

        Destroy(basketItem);
    }
}
