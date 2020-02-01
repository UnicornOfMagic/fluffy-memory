using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var rigidBody = this.GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidBody.MovePosition(Vector3.MoveTowards(rigidBody.position, rigidBody.position + new Vector3(0, 0, speed), 0.1f));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidBody.MovePosition(Vector3.MoveTowards(rigidBody.position, rigidBody.position + new Vector3(0, 0, speed * -1), 0.1f));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidBody.MovePosition(Vector3.MoveTowards(rigidBody.position, rigidBody.position + new Vector3(speed, 0, 0), 0.1f));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidBody.MovePosition(Vector3.MoveTowards(rigidBody.position, rigidBody.position + new Vector3(speed * -1, 0, 0), 0.1f));
        }
    }
}
