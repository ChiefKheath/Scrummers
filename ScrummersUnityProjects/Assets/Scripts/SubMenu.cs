using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMenu : MonoBehaviour
{
    [SerializeField] private GameObject mobilePhonesScrollView, simOnlyScrollView, 
        accessoriesScrollView, tabletsScrollView, tvAndBroadbandScrollView, supportScrollView;
    
    public void MobilePhones()
    {
        SetAllInactive();
        mobilePhonesScrollView.SetActive(true);
    }

    public void SimOnly()
    {
        SetAllInactive();
        simOnlyScrollView.SetActive(true);
    }

    public void Accessories()
    {
        SetAllInactive();
        accessoriesScrollView.SetActive(true);
    }

    public void Tablets()
    {
        SetAllInactive();
        tabletsScrollView.SetActive(true);
    }

    public void TvAndBroadband()
    {
        SetAllInactive();
        tvAndBroadbandScrollView.SetActive(true);
    }

    public void Support()
    {
        SetAllInactive();
        supportScrollView.SetActive(true);
    }

    private void SetAllInactive()
    {
        mobilePhonesScrollView.SetActive(false);
        simOnlyScrollView.SetActive(false);
        tabletsScrollView.SetActive(false);
        accessoriesScrollView.SetActive(false);
        tabletsScrollView.SetActive(false);
        tvAndBroadbandScrollView.SetActive(false);
        supportScrollView.SetActive(false);
    }

    private void Start()
    {
        MobilePhones();
    }
}
