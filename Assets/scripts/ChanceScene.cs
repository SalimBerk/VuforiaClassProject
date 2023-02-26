using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChanceScene : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI label;

    public void ChangeScene()
    {
        if (label.text == "301")
        {
            SceneManager.LoadScene("ApplicationScene");

        }
        else if(label.text == "335")
        {
            SceneManager.LoadScene("ApplicationTwo");

        }
        
    }

}
