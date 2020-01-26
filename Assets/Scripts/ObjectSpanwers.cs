using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpanwers : MonoBehaviour
{

    public GameObject[] Projectileprefab = new GameObject[2]; //a prefab is an object that is not part of the scene. but within the project

    //used for the area where it will spawn in
    public Vector3 size;
    public Vector3 center;
    public float waitSpawn; //wait x amount of time before begin spawning objects
    public int waitMin; //least amount of wait time
    public int waitMax; //max amount of wait time
    public int waitTime; //interval when objects spawn in
    public float scale1;
    public float scale2;

    private int random;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnWait());
    }

    // Update is called once per frame
    void Update()
    {
        waitTime = Random.Range(waitMin, waitMax); //constantly making a new float value of time within this range

    }

    IEnumerator spawnWait()
    {
        yield return new WaitForSeconds(waitSpawn); //waits for x amount of time before spawning

        while(true)
        {
            random = Random.Range(0,Projectileprefab.Length);
            Vector3 spawnPos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), 0, Random.Range(-size.z / 2, size.z / 2)); //this gets the exact coordinates that ranges in the cube FOR each axis

            GameObject obj = Instantiate(Projectileprefab[random], spawnPos, Quaternion.Euler(Random.Range(0.0f, 360f), Random.Range(0.0f, 360f), Random.Range(0.0f, 360f))); //this will spawn the actual object which will be within the randomly generated position
            obj.AddComponent<Object_Movement>();
            obj.AddComponent<Rigidbody>();
            obj.GetComponent<Rigidbody>().mass = 30;
            obj.GetComponent<Rigidbody>().useGravity = true;
            if (random == 0) {
                obj.transform.localScale = new Vector3(scale1, scale1, scale1);
                obj.gameObject.tag = "Collectable";
                obj.AddComponent<BoxCollider>();
                obj.GetComponent<BoxCollider>().isTrigger = false;
            }
            if (random == 1) {
                obj.transform.localScale = new Vector3(scale2, scale2, scale2);
                obj.gameObject.tag = "Bad";
                obj.GetComponent<SphereCollider>().isTrigger = false;
            }

            yield return new WaitForSeconds(waitSpawn);
        }
    }
}
