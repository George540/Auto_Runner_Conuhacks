using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Island_Movement : MonoBehaviour
{

    public float vel = 20f;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(-vel, 0 ,0);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(-vel, 0 ,0);
    }
}
