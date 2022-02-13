using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public int lives;
    public bool canShoot;
    public GameObject gameManagerObject;

    public int playerNum;
    public Vector3 playerpos;
    public bool canJump;
    public Vector3 up;
    public Vector3 left;
    public Vector3 right;
    public KeyCode l;
    public KeyCode r;
    public KeyCode u;
    public KeyCode bul;
    public int isFacing;
    public GameObject rightBlueBullet;
    public GameObject leftBlueBullet;
    public Vector3 rboffset;
    public Vector3 lboffset;
    public float wait;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerObject = GameObject.Find("GameManager");
        lives = 9;
        canShoot = true;
        playerpos = GetComponent<Transform>().position;
        canJump = true;
        isFacing = 1;
    }

    // Update is called once per frame
    void Update()
    {
        wait += Time.deltaTime;

        playerpos = GetComponent<Transform>().position;
        if (Input.GetKey(l))
        {
            isFacing = -1;
            GetComponent<SpriteRenderer>().flipX = false;
            GetComponent<Rigidbody2D>().AddForce(left);
        }
        if (Input.GetKey(r))
        {
            isFacing = 1;
            GetComponent<SpriteRenderer>().flipX = true;
            GetComponent<Rigidbody2D>().AddForce(right);
        }
        if (Input.GetKeyDown(u))
        {
            if (canJump == true)
            {
                canJump = false;
                GetComponent<Rigidbody2D>().AddForce(up);
            }
        }
       if (Input.GetKeyDown(bul) && canShoot && wait >=0.5)
        {
            
            if (isFacing == 1)
            {
                Instantiate(rightBlueBullet, playerpos + rboffset, Quaternion.identity);
            }
            if (isFacing == -1)
            {
                Instantiate(leftBlueBullet, playerpos + lboffset, Quaternion.identity);
            }

            wait = 0;
        } 
        if (lives <= 0)
        {
            Destroy(gameObject);
        }


    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        canJump = true;
        if (collision.gameObject.tag == "death")
        {
            lives--;
        }
    }
}
