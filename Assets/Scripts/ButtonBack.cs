using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ButtonBack : MonoBehaviour
{
    public event Action OnItemsMenu;
    void Start()
    {
        Button buton = GetComponent<Button>();
        buton.onClick.AddListener(ItemsMenu);
    }

    private void ItemsMenu()
    {
        OnItemsMenu?.Invoke();
        Debug.Log("Items Menu Activado");
    }
}
