using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    public Text gameOver;
    public Text score;
    public Text Life;
    int intScore;
    int intLife;
    void Start()
    {
        intScore = 0;
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
            if (intLife < 1) {
                intLife = 0;
                //Text go = Instantiate(gameOver, new Vector3(0, 150.0f, 0), Quaternion.identity) as Text;
                //go.transform.SetParent(canvas.transform, false);
                Vector3 temp = new Vector3(500.0f, 300.0f, 0);    
                gameOver.transform.position = temp;
                StartCoroutine(WaitForSecond()); 
            }
            Life.text = "Life: " + intLife; 
            Destroy(other.gameObject);
        }
     }

     IEnumerator WaitForSecond() {
         Vector3 temp = new Vector3(-100.0f, 0, 0);
         gameObject.transform.position += temp;
         yield return new WaitForSeconds(3);
         SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
     }
     
}
