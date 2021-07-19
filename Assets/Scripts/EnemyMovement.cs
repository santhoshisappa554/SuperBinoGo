using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMovement : MonoBehaviour
{
    public int enemySpeed = 10;
    SpriteRenderer sr;
    Animator anim;
  
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerMovement.instance.playerMove)
        {
            if (gameObject.CompareTag("Enemy1"))
            {
                transform.Translate(enemySpeed * Time.deltaTime, 0, 0);//movement of the obstacle from left to right on x-axis
                if (transform.position.x >= 22.21)
                {
                    enemySpeed = -5;
                    sr.flipX = true;
                }
                else if (transform.position.x <= 6.6)
                {
                    enemySpeed = 5;
                    sr.flipX = false;
                }
            }
            else if (gameObject.CompareTag("Enemy2"))
            {
                transform.Translate(enemySpeed * Time.deltaTime, 0, 0);//movement of the obstacle from left to right on x-axis
                if (transform.position.x >= 51.18)
                {
                    enemySpeed = -5;
                    sr.flipX = true;
                }
                else if (transform.position.x <= 35.11)
                {
                    enemySpeed = 5;
                    sr.flipX = false;
                }
            }
            else if (gameObject.CompareTag("Enemy3"))
            {
                transform.Translate(enemySpeed * Time.deltaTime, 0, 0);//movement of the obstacle from left to right on x-axis
                if (transform.position.x >= 70.76)
                {
                    enemySpeed = -5;
                    sr.flipX = true;
                }
                else if (transform.position.x <= 63.68)
                {
                    enemySpeed = 5;
                    sr.flipX = false;
                }
            }
            else if (gameObject.CompareTag("Enemy4"))
            {
                transform.Translate(enemySpeed * Time.deltaTime, 0, 0);//movement of the obstacle from left to right on x-axis
                if (transform.position.x >= 138.8)
                {
                    enemySpeed = -5;
                    sr.flipX = true;
                }
                else if (transform.position.x <= 131.5)
                {
                    enemySpeed = 5;
                    sr.flipX = false;
                }
            }
        }
        else
        {
            anim.enabled = false;
        }
            

        }
    }
        

