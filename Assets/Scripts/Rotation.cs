using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotation : MonoBehaviour {

    public float speed = 1.0f;
    public float max = 315f;
    public float min = 225f;

    public float angleX;

    // Start is called before the first frame update
    void Start()
    {
        
    }
//270
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)){
            //float rotation = -speed * Input.GetAxis("Mouse X");

            float rotation = -speed *-0.4f;
            transform.Rotate(rotation, 0, 0);

            angleX = transform.eulerAngles.x;

            Vector3 rot = transform.eulerAngles;
            Debug.Log(rot);
            if (rot.x > max) {
                rot.x = max;
                transform.eulerAngles = rot;
            }
            if (rot.x < min) {
                rot.x = min;
                transform.eulerAngles = rot;
            }
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            //float rotation = -speed * Input.GetAxis("Mouse X");

            float rotation = -speed *0.4f;
            transform.Rotate(rotation, 0, 0);

            angleX = transform.eulerAngles.x;

            Vector3 rot = transform.eulerAngles;
            Debug.Log(rot);
            if (rot.x > max) {
                rot.x = max;
                transform.eulerAngles = rot;
            }
            if (rot.x < min) {
                rot.x = min;
                transform.eulerAngles = rot;
            }
        }
    }

}