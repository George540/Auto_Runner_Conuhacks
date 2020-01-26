using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    //[Serializable] private GameObject player;
    Vector3 move = new Vector3(-1,0,0);
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = transform.position + move;
    }
}
