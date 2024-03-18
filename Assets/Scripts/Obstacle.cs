using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 10.0f;

    public float end = 1.0f;
    private deleter deleterScript;


    // Start is called before the first frame update
    void Start()
    {
        deleterScript = GetComponent<deleter>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        // Make sure this calculation is frame rate independent (hint: use Time.deltaTime)


        // TODO: If the obstalce is off screen to the left, destroy this GameObject (hint: Destroy(gameObject))
        if (transform.position.y >= end)
        {
            Destroy(gameObject);
        }

        if (deleterScript != null)
        {
            int scoreCount = deleterScript.scoreCount;
            Debug.Log("Score count " + scoreCount);
            if (scoreCount >= 3)
            {
                speed = 20.0f;
            }
        }
    }
}