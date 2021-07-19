using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float playerSpeed;
    public float jumpSpeed;
    public bool isGrounded;
    Animator animator;
    public int score = 0;
    public Text scoreText;
    SpriteRenderer spriteRenderer;
    public Canvas canvas;
    public bool playerMove=true;
    public GameObject player;
    public static PlayerMovement instance;
    public int highscore = 0;
    

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMove == true)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                rb.velocity = new Vector2(playerSpeed, 0);
                spriteRenderer.flipX = false;

                animator.SetTrigger("Run");

            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rb.velocity = new Vector2(-playerSpeed, 0);
                spriteRenderer.flipX = true;
                animator.SetTrigger("Run");
            }

            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (isGrounded == true)
                {
                    Jump();
                }
            }
            else
            {
                animator.SetTrigger("Idle");
            }
        }
            
        
    }

    
    public void Jump()
    {
        rb.velocity = new Vector2(0,jumpSpeed);
        animator.SetTrigger("Jump");
        isGrounded = false;
    }
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        else if (collision.gameObject.CompareTag("coin"))
        {
            if (playerMove)
            {
                score = score + 5;
                print("Score: " + score);
                scoreText.text = "Score: " + score.ToString();
                Destroy(collision.gameObject, 0.0f);
                animator.enabled = false;
            }
            
        }
        else if (collision.gameObject.CompareTag("Enemy1")|| collision.gameObject.CompareTag("Enemy2")||collision.gameObject.CompareTag("Enemy3")|| collision.gameObject.CompareTag("Water"))
        {
            //Destroy(this.gameObject);
            animator.SetTrigger("Dead");
            playerMove = false;
            canvas.gameObject.SetActive(true);
            
            
        }
        
        else if (collision.gameObject.CompareTag("Castle"))
        {
            SceneManager.LoadScene(1);
        }
        

    }
    
   
}
