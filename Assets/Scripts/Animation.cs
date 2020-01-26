using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
   public float speedUpDown = 1;
   public float distanceUpDown = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     Vector3 mov = new Vector3 (transform.position.x, (Mathf.Sin(speedUpDown * Time.time) * distanceUpDown)+2.5f, transform.position.z);
         transform.position = mov;
	  
    }
}
