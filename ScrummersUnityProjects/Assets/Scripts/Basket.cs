using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Basket : MonoBehaviour
{
    public GameObject basketUI;
    public bool UIisUP = false;
    [SerializeField] private GridLayoutGroup basketGridView;
    [SerializeField] private BasketItems basketItems;
    [SerializeField] private GameObject itemPrefab;

    public void BasketClick()
    {
        UIisUP = !UIisUP;
        basketUI.SetActive(UIisUP);

        foreach(Transform child in basketGridView.transform)
        {
            Destroy(child.gameObject);
        }

        foreach (GameObject item in basketItems.items)
        {
            string info = item.GetComponentInChildren<TMP_Text>().text;
            GameObject basketItem = Instantiate(itemPrefab);
            basketItem.transform.SetParent(basketGridView.transform);
            basketItem.GetComponentInChildren<TMP_Text>().text = info;
        }
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
