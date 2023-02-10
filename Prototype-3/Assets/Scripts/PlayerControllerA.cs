using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerA : MonoBehaviour
{
    private Rigidbody playerRB;
    public float jumpForce = 10;
    private Animator playerAnim;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerAnim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
        }
    }

    private void  OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.CompareTag("Grounde"))
        {
            isOnGround = true;
        }   else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Failure");
            gameOver = true;
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
        }
    }

}

