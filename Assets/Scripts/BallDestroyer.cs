using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroyer : MonoBehaviour
{

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Collectable" || other.gameObject.tag == "Bad") {
            DestroyObject(other.gameObject);
        }
     }
}
