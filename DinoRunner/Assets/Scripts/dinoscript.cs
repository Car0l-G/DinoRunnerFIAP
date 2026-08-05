using UnityEngine;

public class dinoscript : MonoBehaviour
{
    [SerializeField] private float jumpforce = 8.0f;

    private Rigidbody2D rigidBody2D;
    private AudioSource audioSource;

    private bool onGround;
    private bool jumping;

private void Awake()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        //input do controle
        if (Input.GetButtonDown("Jump") && onGround == true)

        {
            jumping = true;
            audioSource.Play();
        }
    }

    private void FixedUpdate()
    {
        if (jumping == true)
        {
            rigidBody2D.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
            jumping = false;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Cactus")
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            onGround = true;
        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            onGround = false;
        }
    }
}
