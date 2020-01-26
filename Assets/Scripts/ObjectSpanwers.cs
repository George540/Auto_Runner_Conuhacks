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
    /*
        public void SpawnObjects() //spawns the random flying objects (projectiles, crates, etc)
        {
            Vector3 spawnPos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), 0, Random.Range(-size.z / 2, size.z / 2)); //this gets the exact coordinates that ranges in the cube FOR each axis

            Instantiate(Projectileprefab, spawnPos, Quaternion.identity); //this will spawn the actual object which will be within the randomly generated position 

        }*/


    void OnDrawSpawn() //this is the shape that is used to spawn objects into (i.e, where random objects will spawn)
    {
        Gizmos.color = new Color(1, 0, 0, 0.75f); //color rgb range (3), alpha

        Gizmos.DrawCube(center, size); //draw the cube using these parameters size and center

    }

    IEnumerator spawnWait()
    {
        yield return new WaitForSeconds(waitSpawn); //waits for x amount of time before spawning

        while(true)
        {

            random = Random.Range(0,Projectileprefab.Length);
            Vector3 spawnPos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), 0, Random.Range(-size.z / 2, size.z / 2)); //this gets the exact coordinates that ranges in the cube FOR each axis

            Instantiate(Projectileprefab[random], spawnPos, Quaternion.identity); //this will spawn the actual object which will be within the randomly generated position 

            yield return new WaitForSeconds(waitSpawn);
        }
    }
}
