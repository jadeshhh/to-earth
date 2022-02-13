using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public int click;
    public float clicks;

     void Start()
    {
        click = 0;
    }

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            click++;
            Debug.Log("Clicked");
        }

        if(click == clicks)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
