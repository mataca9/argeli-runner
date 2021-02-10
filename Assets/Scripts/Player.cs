using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigidBody;

    private float jumpForce = 7f;
    private float startJump;
    private float delay = 1f;
    private float nextJump = 0;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && nextJump < Time.time) {
            startJump = Time.time;
            nextJump = Time.time + delay;
            rigidBody.velocity = Vector3.up * jumpForce;
        }
    }
}
