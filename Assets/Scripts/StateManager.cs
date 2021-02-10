using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public Text gameOverText;
    [SerializeField]
    private GameObject obstaclePrefab;
    // Start is called before the first frame update
    void Start()
    {
        // Score
        score = 0;

        // Spawns
        StartCoroutine(SpawnObstacle());
    }


    public void UpdateScore(int points) {
        if (!gameOverText.enabled) {
            score += points;
            scoreText.text = "Score: " + score;
        }
    }

    public void GameOver() {
        gameOverText.enabled = true;
    }

    IEnumerator SpawnObstacle() {
        while(!gameOverText.enabled) {
            // spawn        
            Instantiate(obstaclePrefab, new Vector3(10, -4, 0), Quaternion.identity);
            yield return new WaitForSeconds(5);
        }
    }
}
