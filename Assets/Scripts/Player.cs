using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Rigidbody2D))]

public class Player : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Collider2D playerCollider;
    public float jump = 10.0f;
    public bool isFalling = true;
    public Color hitColor;
    public Color origionalColor;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        origionalColor = spriteRenderer.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isFalling)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb2d.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        print("On Collision Enter");
        if (other.gameObject.CompareTag("Ground")) 
        {
            isFalling = false;
        }
        if (other.gameObject.CompareTag("Obstacle"))
        {
            spriteRenderer.color = hitColor;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isFalling = true;
        }
        if (other.gameObject.CompareTag("Obstacle"))
        {
            spriteRenderer.color = origionalColor;
        }
    }

}
