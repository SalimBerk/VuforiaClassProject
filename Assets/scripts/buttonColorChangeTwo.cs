using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonColorChangeTwo : MonoBehaviour
{
    public GameObject button2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    public void ColorChange()
    {
        button2.GetComponent<Image>().color = Color.blue;
        button2.GetComponentInChildren<Text>().color = Color.white;



    }
}
