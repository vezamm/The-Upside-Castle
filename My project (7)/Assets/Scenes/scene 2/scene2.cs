using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene2 : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this speed as needed
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private bool rotated = false;
    public bool testsc2 = false;
    public bool testkey = false;
    public GameObject fhandle;
    public GameObject handle;
    public GameObject chessc;
    public GameObject chesso;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        handle.gameObject.SetActive(false);
        fhandle.gameObject.SetActive(true);
        chessc.gameObject.SetActive(true);
        chesso.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = Vector2.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movement = Vector2.left * moveSpeed;
            spriteRenderer.flipX = true;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            movement = Vector2.right * moveSpeed;
            spriteRenderer.flipX = false;
        }

        rb.velocity = new Vector2(movement.x, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.G))
        {
            RotateCharacter();
        }
    }

    void RotateCharacter()
    {
        // Toggle the rotated flag
        rotated = !rotated;

        // Rotate the character
        transform.Rotate(new Vector3(0, 0, 180));

        // Adjust the gravity based on the rotation
        if (rotated)
        {
            rb.gravityScale = -6f;
            // If walking on the ceiling, set the velocity to move upwards
            rb.velocity = Vector2.up * moveSpeed;
        }
        else
        {
            rb.gravityScale = 6f;
            // If walking on the floor, set the velocity to move downwards
            rb.velocity = Vector2.down * moveSpeed;
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == "door" && testsc2 == true)
        {
            SceneManager.LoadScene("hideen room");
        }
        if (other.name == "door2")
        {
            SceneManager.LoadScene("scene2");
        }
        if (other.name == "fhandle" && Input.GetKeyDown(KeyCode.E))
        {
            
            fhandle.gameObject.SetActive(false);
            handle.gameObject.SetActive(true);
            testsc2 = true;
            
        }
        if (other.name == "key1" )
        {

            Destroy(other.gameObject);
            testkey = true;

        }
        if (other.name == "chessc" && testkey == true)
        {
            chessc.gameObject.SetActive(false);
            chesso.gameObject.SetActive(true);
        }
        


    }
}
