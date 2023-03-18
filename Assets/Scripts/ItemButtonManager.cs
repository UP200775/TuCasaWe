using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class ItemButtonManager : MonoBehaviour
{
    
    public Item item;
    private string itemCompany;
    private string itemName;
    private Sprite itemImage;
    private string itemDescription;
    private GameObject item3DModel;
    private string itemDimensions;
    private string itemPrice;
    private ARInteractionManager interactionManager;

    public string ItemName { set => itemName = value; }
    public string ItemCompany { set => itemCompany = value; }
    public string ItemDescription { set => itemDescription = value; }
    public Sprite ItemImage { set => itemImage = value; }
    public GameObject Item3DModel { set => item3DModel = value; }
    public string ItemDimensions { set => itemDimensions = value; }
    public string ItemPrice { set => itemPrice = value; }

    void Start()
    {
        transform.GetChild(0).GetComponent<Text>().text = itemCompany;
        transform.GetChild(1).GetComponent<Text>().text = itemName;
        transform.GetChild(2).GetComponent<RawImage>().texture = itemImage.texture;
        transform.GetChild(3).GetComponent<Text>().text = itemDescription;
        transform.GetChild(4).GetComponent<Text>().text = itemDimensions;
        
        item3DModel = Resources.Load<GameObject>("Item3DModel");
        
        interactionManager = FindObjectOfType<ARInteractionManager>();

        var button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClicked);
        button.onClick.AddListener(GameManager.instance.ItemsBuy);
    }

    private void Create3DModel()
    {
        Instantiate(item.Item3DModel);
    }


    private void OnButtonClicked()
    {
        // Guardar el objeto seleccionado en el GameManager
        GameManager.instance.selected_item = item;
       
        // Obtener los objetos del prefab del canvas
        GameObject canvas_prefab = GameObject.Find("ItemsBuyCanvas");
        GameObject item_company_text = canvas_prefab.transform.Find("ItemCompany").gameObject;
        GameObject item_name_text = canvas_prefab.transform.Find("ItemName").gameObject;
        GameObject item_description_text = canvas_prefab.transform.Find("ItemDescription").gameObject;
        GameObject item_dimensions_text = canvas_prefab.transform.Find("ItemDimensions").gameObject;
        GameObject item_image = canvas_prefab.transform.Find("Image").gameObject;
        GameObject item_price_text = canvas_prefab.transform.Find("ItemPrice").gameObject;
        GameObject item_see_button = canvas_prefab.transform.Find("See").gameObject;
        Button seeButton = item_see_button.GetComponent<Button>();

            seeButton.onClick.AddListener(() =>
            {
                Create3DModel();
            });

        // Mostrar los datos del objeto scriptable en el canvas
        item_company_text.GetComponent<Text>().text = itemCompany;
        item_name_text.GetComponent<Text>().text = itemName;
        item_description_text.GetComponent<Text>().text = itemDescription;
        item_image.GetComponent<Image>().sprite = itemImage;
        item_dimensions_text.GetComponent<Text>().text = itemDimensions;
        item_price_text.GetComponent<Text>().text = itemPrice;

        // Activar el objeto del prefab del canvas
        canvas_prefab.SetActive(true);
    }

}
