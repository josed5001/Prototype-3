using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private PlayerControllerA PlCtScript;
    private float leftBound  = -15;
    // Start is called before the first frame update
    void Start()
    {
        PlCtScript = GameObject.Find("Player").GetComponent<PlayerControllerA>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlCtScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
