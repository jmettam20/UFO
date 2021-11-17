using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class captureHumansScript : MonoBehaviour
{
    private float score = 0;

    public TextMeshProUGUI scoreNumber;

    
   

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.transform.tag == "Humans")
        {
            score++;
            scoreNumber.text = score.ToString();
            Destroy(other.gameObject);
        }
    }
}
