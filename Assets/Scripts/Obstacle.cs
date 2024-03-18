using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float initialSpeed = 10.0f;
    public float maxSpeed = 20.0f;
    public float speedIncreaseAmount = 2.0f;
    private float speed;

    public float end = 1.0f;
    private deleter deleterScript;


    // Start is called before the first frame update
    void Start()
    {
        
        deleterScript = GetComponent<deleter>();
    }

    // Update is called once per frame
    void Update()
    {        // Make sure this calculation is frame rate independent (hint: use Time.deltaTime)


        // TODO: If the obstalce is off screen to the left, destroy this GameObject (hint: Destroy(gameObject))
        if (transform.position.y >= end)
        {
            Destroy(gameObject);
        }

        if (deleterScript != null && deleterScript.scoreCount >= 3)
        {
            IncreaseSpeed();
        }

        MoveObstacle();
    }


        void IncreaseSpeed()
        {
            speed += speedIncreaseAmount * Time.deltaTime;
            speed = Mathf.Min(speed, maxSpeed);
        }

        void MoveObstacle()
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
}