using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float strafeSpeed;
    public float jumpForce=16000;
    public Rigidbody hips;
    public bool isGrounded;



    void Start()
    {
        hips = GetComponent<Rigidbody>();
    }

    private void FixedUpdate(){
        if(Input.GetKey(KeyCode.UpArrow)){
            hips.AddForce(hips.transform.forward * speed);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            hips.AddForce(-hips.transform.forward * speed);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            hips.AddForce(-hips.transform.right * speed);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            hips.AddForce(hips.transform.right * speed);
        }
        if(Input.GetKey(KeyCode.Space)){
            if(isGrounded){
                hips.AddForce(new Vector3(0,jumpForce,0));
                isGrounded=false;
            }
            
        }
    }
   
}
