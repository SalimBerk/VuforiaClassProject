using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TransitionScenes : MonoBehaviour
{
    public void ARSayfasi()
    {
        SceneManager.LoadScene("ApplicationScene");
    }
    public void ARSayfasiTwo()
    {
        SceneManager.LoadScene("ApplicationTwo");
    }
    public void Cikis()
    {
        Application.Quit();
        Debug.Log("Uygulamadan Çýkýldý.");
    }


}
