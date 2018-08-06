using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spawn : MonoBehaviour {

    public Transform npcAgent;
    public Transform spawnObject;
    public int SpawnCount = 1;
    
	// Use this for initialization
	void Start () {
                        
   	}
	
	// Update is called once per frame
	void Update () {
        if(SpawnCount > 0)
        {
            Instantiate(npcAgent, spawnObject.transform.position, Quaternion.identity);
            SpawnCount--;
        }
                
    }
}
