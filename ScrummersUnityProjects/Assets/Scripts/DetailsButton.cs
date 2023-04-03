using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetailsButton : MonoBehaviour
{
    public GameObject detailPanel;

    public void openPanel()
    {
        detailPanel.SetActive(true);
    }

    public void closePanel()
    {
        detailPanel.SetActive(false);
    }
}
