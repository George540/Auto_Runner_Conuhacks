using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandDestroyer : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Island") {
            DestroyObject(other.gameObject);
        }
    }
}
