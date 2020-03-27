using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Collision : MonoBehaviour
{
    GameObject player;
    public float timer;
   
    public Text text2; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider collidedObject) {
        if (collidedObject.tag == "Enemy")
            
        {
            text2.text = timer.ToString();
          
         Destroy(this.gameObject); SceneManager.LoadScene("Startgame");
           
        }
        

    }
}
