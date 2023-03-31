using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PopulateCheckout : MonoBehaviour
{
    [SerializeField] private BasketItems basketItems;
    [SerializeField] private GameObject checkoutItemPrefab;
    [SerializeField] private GridLayoutGroup checkoutGridLayoutGroup;
    private int infoSeperationIndex;
    public float total;
    [SerializeField] private GameObject priceGameObject;

    public void Populate()
    {
        foreach (GameObject item in basketItems.items)
        {
            string info = item.GetComponentInChildren<TMP_Text>().text;
            GameObject checkoutItem = Instantiate(checkoutItemPrefab);
            checkoutItem.transform.SetParent(checkoutGridLayoutGroup.transform);
            checkoutItem.GetComponentInChildren<TMP_Text>().text = info;
        }
    }

    public void CalculateTotal()
    {
        foreach (GameObject item in basketItems.items)
        {
            string info = item.GetComponentInChildren<TMP_Text>().text;

            string[] seperatedInfo = info.Split("£");

            foreach(string infoSegment in seperatedInfo)
            {
                infoSeperationIndex++;

                if(infoSeperationIndex == 2)
                {
                    float price = float.Parse(infoSegment);

                    total += price;
                    infoSeperationIndex = 0;
                }
            }
        }

        priceGameObject.GetComponent<TMP_Text>().text = total.ToString();
    }
}
