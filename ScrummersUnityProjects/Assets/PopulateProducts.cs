using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PopulateProducts : MonoBehaviour
{
    [SerializeField] private GridLayoutGroup gridLayoutGroup;
    private string[,] productInfo;
    [SerializeField] private GameObject itemPrefab;

    // Start is called before the first frame update
    void Start()
    {
        productInfo = new string[3, 3] {
            {"iPhone","X","64gb"},
            {"iPhone","XR","64gb"},
            {"iPhone","14","128gb"}
        };

        gridLayoutGroup = GetComponent<GridLayoutGroup>();

        foreach(string product in productInfo)
        {
            GameObject newItem = Instantiate(itemPrefab);
            newItem.GetComponent<TMP_Text>().text = product[0] + " " + product[1] + ", " + product[2];
            newItem.transform.SetParent(gridLayoutGroup.transform);
        }
    }
}
