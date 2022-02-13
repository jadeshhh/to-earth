using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovementScript : MonoBehaviour
{
    public float move;
    public float time;
    public GameObject gameManagerObject;
    // Start is called before the first frame update
    void Start()
    {
        gameManagerObject = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;
        
        if (time <= 5)
        {
                GetComponent<Rigidbody2D>().velocity = new Vector2(move, 0f);
        }

        if (time > 5)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
