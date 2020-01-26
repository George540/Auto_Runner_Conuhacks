using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    public Text score;
    public Text Life;
    int intScore;
    int intLife;
    void Start()
    {
        intScore =0;
        intLife = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Collectable") {
            intScore++;
            score.text = "Score: " + intScore; 
            Destroy(other.gameObject);
        }
        if (other.tag == "Bad") {
            intLife--;
            Life.text = "Life: " + intLife; 
            Destroy(other.gameObject);
        }
     }
}
