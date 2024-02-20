using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{

    public GameObject pipe;
    private float maxHeight = 3.5f;
    private float minHeight = -2.6f;
    private float timer = 0f;
    private float spawnTime = 1.5f;
   

    // Start is called before the first frame update

    
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTimer();
        
    }

    private void SpawnTimer() {
        if (timer < spawnTime) {
            timer += Time.deltaTime;
        }
        else {
            SpawnPipe();
            timer = 0f;
        }
    }
    
    private void SpawnPipe() {
        if (CharacterMovement.IsAlive) {
            Instantiate(pipe, pipe.transform.position + new Vector3(0, Random.Range(minHeight, maxHeight), 0), pipe.transform.rotation);
        }
    }






}
