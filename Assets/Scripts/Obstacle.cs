using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    private float speed = 3f;

    private StateManager stateManager;

    // Start is called before the first frame update
    void Start()
    {
        stateManager = GameObject.Find("Canvas").GetComponent<StateManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.right * Time.deltaTime * speed);

        if (transform.position.x < -9.6) {
            stateManager.UpdateScore(100);
            Destroy(gameObject);
        } 
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Destroy(other.gameObject);
            Destroy(gameObject);
            stateManager.GameOver();
        }
    }
}