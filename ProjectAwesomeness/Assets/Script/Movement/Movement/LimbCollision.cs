using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimbCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerController playerController;

    private void Start(){
        playerController= GameObject.FindObjectOfType<PlayerController>().GetComponent<PlayerController>();
    }
    private void OnCollisionEnter(Collision collision){
        playerController.isGrounded = true;
    }
}
