using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonColorChange : MonoBehaviour
{
    public GameObject button;
   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void ColorChange()
    {
        button.GetComponent<Image>().color = Color.blue;
        button.GetComponentInChildren<Text>().color = Color.white;
       
        


    }
}
