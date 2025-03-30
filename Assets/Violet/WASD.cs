using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float Health = 100f;
    public float HealthAtStart = 100f;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;
    public float speed = 4.0f;
    public float run = 3.0f;
    public float sneak = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Health = HealthAtStart;
    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            Debug.Log("you are dead now");
            SceneManager.LoadScene("Scenes/Secrets of the Farm");
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 3.0f * run;
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            speed = 4.0f * sneak;
        }
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
            spriteRenderer.flipX = false;
        else if (Input.GetKey(KeyCode.A))
            spriteRenderer.flipX = true;

        
    }
    
}

