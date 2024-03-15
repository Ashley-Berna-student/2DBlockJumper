using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deleter : MonoBehaviour
{
    public Text endText;
    public GameObject endGameObject;
    public Text score;
    public int scoreCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        endGameObject.SetActive(false);
        endText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        print(other.gameObject.tag);
        if (other.gameObject.CompareTag("Obstacle"))
        {
            scoreCount++;
            UpdateScore();
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Player"))
        {
            EndGame();
        }
    }

    private void UpdateScore()
    {
        score.text = "Triangles Jumped: " + scoreCount.ToString();
    }

    void EndGame()
    {
        endText.gameObject.SetActive(true);
        endGameObject.SetActive(true);
        print("Game Over");
        Time.timeScale = 0f;
    }
}
