using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ToLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer;
    public void GotoMainScene()
    {
        SceneManager.LoadScene("s");

        
    }
    public void Timer1()
    {
     

        timer = 0;
    }

    public void GotoControls()
    {
        SceneManager.LoadScene("C");


    }
    public void GotoHome()
    {
        SceneManager.LoadScene("Startgame");


    }
}

