using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionSceneTwo : MonoBehaviour
{
    // Start is called before the first frame update
    public void Lessons()
    {
        SceneManager.LoadScene("LessonScenes");
    }
    public void Cikis()
    {
        Application.Quit();
        Debug.Log("Uygulamadan Çýkýldý.");
    }




}
