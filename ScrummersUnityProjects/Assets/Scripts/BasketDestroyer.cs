using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketDestroyer : MonoBehaviour
{
    public GameObject basketItem;
    public void Destroyer()
    {
        Destroy(basketItem);
    }
}
