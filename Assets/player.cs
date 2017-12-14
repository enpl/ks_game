using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class player : MonoBehaviour {


    private NavMeshAgent nav;
    //플레이어 움직임속도
    public float moveSpeed = 5f;
    //플레이어 방향회전속도
    public float rotationSpeed = 120f;
    
    
    public GameObject Marker;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        //움직이자!
        float horizontal = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);
        //움직이자!(2)
        float vertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, 0, vertical); ;
        
        Marker.transform.position = new Vector3(this.transform.position.x, Marker.transform.position.y, this.transform.position.z);
        Marker.transform.forward = this.transform.forward;
        
        
    }
}