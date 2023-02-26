using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class hoverClip : MonoBehaviour
{
    // Start is called before the first frame update
    public RectTransform Button;
    void Start()
    {
        Button.GetComponent<Animator>().Play("Hover Off");
        
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        Button.GetComponent<Animator>().Play("Hover On");

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Button.GetComponent<Animator>().Play("Hover Off");

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
