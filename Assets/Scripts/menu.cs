using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    public Image panel;
    
    //inicio penu pausa
    void fadePanel(float fade)
    {
        Color c = panel.color;
        c.a = fade;
        panel.color = c;
        
    }
    public void pausa()
    {
        fadePanel(0.3f);
        Time.timeScale = 0;
               
    }

    public void resume()
    {
        fadePanel(0f);
        Time.timeScale = 1;
    }

    public void backToMain()
    {
        SceneManager.LoadScene(0);
    }

    //inicio menu principal
    public void startGame()
    {
        //panel.CrossFadeAlpha(1f, 2f, true);
        SceneManager.LoadScene(1);
    }

    public void transicionAJuego()
    {
        //panel.CrossFadeAlpha(1f, 2f, false);
    }


    // Update is called once per frame

}
