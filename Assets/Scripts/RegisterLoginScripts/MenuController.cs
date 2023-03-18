using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Establece la escala inicial del Canvas a cero
        transform.localScale = Vector3.zero;

        // Anima la escala del Canvas para que aparezca gradualmente
        transform.DOScale(Vector3.one, 1f);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
