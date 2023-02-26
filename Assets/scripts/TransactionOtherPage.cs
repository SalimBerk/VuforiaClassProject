using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransactionOtherPage : MonoBehaviour
{
    // Start is called before the first frame update
    public void otherPage()
    {
        SceneManager.LoadScene("ClassList");
    }

    public void backPage()
    {
        SceneManager.LoadScene("LessonScenes");

    }
    public void exit()
    {
        Application.Quit();
        Debug.Log("Uygulamadan Çýkýldý.");

    }
}
