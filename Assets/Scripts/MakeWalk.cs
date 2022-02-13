using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MakeWalk : MonoBehaviour
{
    public int click;
    public float clicks;
    public GameObject panel;

    void Start()
    {
        click = 0;
        panel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            click++;
            Debug.Log("Clicked");
        }

        if (click == clicks)
        {
            panel.SetActive(true);
            click = 0;
        }
    }
}
