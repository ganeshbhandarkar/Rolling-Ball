using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreUI;
    public int score; 
    // Start is called before the first frame update
 

    // Update is called once per frame
    void Update()
    {
        scoreUI.text = score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collider is working");
        if(other.gameObject.tag == "scoreup")
        {
            score++;  
        }
    }
}
