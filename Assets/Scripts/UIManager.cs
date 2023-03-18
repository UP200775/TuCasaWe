using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuCanvas;
    [SerializeField] private GameObject itemsMenuCanvas;
    [SerializeField] private GameObject ARPositionCanvas;
    [SerializeField] private GameObject ItemsBuyCanvas;
    void Start()
    {
        GameManager.instance.OnMainMenu += ActivateMainMenu;
        GameManager.instance.OnItemsMenu += ActivateItemsMenu;
        GameManager.instance.OnARPosition += ActivateARPosition;
        GameManager.instance.OnItemsBuy += ActivateItemsBuy;
    }
    private void ActivateItemsBuy()
    {
        itemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        itemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemsMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemsMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemsMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        itemsMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemsMenuCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemsMenuCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemsMenuCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        ARPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        ARPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        ItemsBuyCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        ItemsBuyCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        ItemsBuyCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        ItemsBuyCanvas.transform.GetChild(3).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        ItemsBuyCanvas.transform.GetChild(4).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        ItemsBuyCanvas.transform.GetChild(5).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        ItemsBuyCanvas.transform.GetChild(6).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        ItemsBuyCanvas.transform.GetChild(7).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        ItemsBuyCanvas.transform.GetChild(8).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        ItemsBuyCanvas.transform.GetChild(9).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        ItemsBuyCanvas.transform.GetChild(10).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        ItemsBuyCanvas.transform.GetChild(11).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        ItemsBuyCanvas.transform.GetChild(12).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        ItemsBuyCanvas.transform.GetChild(13).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
    }
    private void ActivateMainMenu()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        
        itemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        itemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemsMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemsMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemsMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        itemsMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemsMenuCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemsMenuCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemsMenuCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        ARPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        ARPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        ItemsBuyCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(9).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(10).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(11).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(12).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(13).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
    }
    private void ActivateARPosition()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        itemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        itemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemsMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemsMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemsMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        itemsMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemsMenuCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemsMenuCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemsMenuCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        ARPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        ARPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        ItemsBuyCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(9).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(10).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(11).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(12).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(13).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
    }
    private void ActivateItemsMenu()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        itemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        itemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        itemsMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        itemsMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        itemsMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        itemsMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        itemsMenuCanvas.transform.GetChild(6).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        itemsMenuCanvas.transform.GetChild(7).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        itemsMenuCanvas.transform.GetChild(8).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        ItemsBuyCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(9).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(10).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(11).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(12).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsBuyCanvas.transform.GetChild(13).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
    }
}
