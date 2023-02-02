using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerA : MonoBehaviour
{
    private Rigidbody playerRB;
    public float jumpForce = 10;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
