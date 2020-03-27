using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    GameObject Player;
    public float timer = 0.0f;
    public Text text;
    public Text endtext;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        text.text = timer.ToString("0.00");

    }
    

}
