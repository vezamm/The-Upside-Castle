using UnityEngine;
using UnityEngine.UI;

public class mouvement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private bool rotated = false;
    private bool fliB = false;
    public float audioVolume = 1.0f;
    private AudioSource audioSource;
    public AudioClip jump;
    public Button moveRightButton;
    public Button moveLeftButton;
    public Button gButton;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = gameObject.AddComponent<AudioSource>();

        // UpdateVolume(); // Set the initial volume

        // Subscribe to the onValidate callback to detect changes in the Inspector


        // Attach the button click listeners
        //moveRightButton.onClick.AddListener(MoveRight);
        //moveLeftButton.onClick.AddListener(MoveLeft);
        //gButton.onClick.AddListener(OnGButtonClick);
    }
    Vector2 movement = Vector2.zero;
    void Update()
    {
        Vector2 movement = Vector2.zero;

        // Handle arrow key input       
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movement = Vector2.left * moveSpeed;
            spriteRenderer.flipX = true;
            rb.velocity = new Vector2(movement.x, rb.velocity.y);
            //movement = Vector2.left * moveSpeed;
            //rb.velocity = new Vector2(movement.x, rb.velocity.y);
            //spriteRenderer.flipX = false;
            //movement = Vector2.left * moveSpeed;
            //spriteRenderer.flipX = true;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(movement.x, rb.velocity.y);
            movement = Vector2.right * moveSpeed;
            spriteRenderer.flipX = false;

        }



        // Handle G key input
        if (Input.GetKeyDown(KeyCode.G) && !fliB)
        {
            audioSource.clip = jump;
            audioSource.Play();
            RotateCharacter();
            rotated = true;
            spriteRenderer.flipY = true;
            fliB = true;
        }
        else if (Input.GetKeyDown(KeyCode.G) && fliB)
        {
            rotated = false;
            spriteRenderer.flipY = false;
            fliB = false;
        }
    }

    /*public void MoveLeft()
    {
       // Vector2 movement = Vector2.zero;
        Vector2 movement = Vector2.right * moveSpeed;
        rb.velocity = new Vector2(movement.x, rb.velocity.y);
        spriteRenderer.flipX = false;
        movement = Vector2.left * moveSpeed;
        spriteRenderer.flipX = true;
    }*/

    /*public void MoveRight()
     {
         //Vector2 movement = Vector2.zero;
         /*Vector2 movement = Vector2.left * moveSpeed;
         rb.velocity = new Vector2(movement.x, rb.velocity.y);
         spriteRenderer.flipX = true;
         movement = Vector2.right * moveSpeed;
         spriteRenderer.flipX = false;
     }*/

    void RotateCharacter()
    {
        rb.gravityScale = -1f;
    }

    /* void OnPlayModeStateChanged(UnityEditor.PlayModeStateChange state)
     {
         if (state == UnityEditor.PlayModeStateChange.EnteredEditMode || state == UnityEditor.PlayModeStateChange.EnteredPlayMode)
         {
             UpdateVolume();
         }
     }

     void UpdateVolume()
     {
         audioSource.volume = audioVolume;
     }*/
}
