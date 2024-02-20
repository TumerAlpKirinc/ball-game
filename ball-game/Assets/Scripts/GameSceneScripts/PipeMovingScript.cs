using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovingScript : MonoBehaviour
{


    [SerializeField] private float moveSpeed = 3f;
    Transform pipeTransform;
    private int destroy = -7; //destroy coordinate
    

    private void Awake() {
        pipeTransform = gameObject.GetComponent<Transform>();
        
        
    }


   

    // Update is called once per frame
    void Update()
    {
        PipeMove();
        PipeDelete();
        
        
    }

    private void PipeMove() {
        pipeTransform.position = pipeTransform.position + Vector3.left * moveSpeed*Time.deltaTime;
        
    }
    private void PipeDelete() {
        if (pipeTransform.transform.position.x < destroy) {
            Destroy(gameObject);
        }

    }
    





}
