using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DropdownScript : MonoBehaviour
{
    public TMP_Dropdown TextBox;
    void Start()
    {
        var dropdown = transform.GetComponent<Dropdown>();
        dropdown.options.Clear();
        List<string> items = new List<string>();
        
        items.Add("301");
        items.Add("335");
        foreach (var item in items)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text=item});

        }
        

        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
