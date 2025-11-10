using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class EndPortal : MonoBehaviour
{

    public bool finalLevel;
    public string nextLevelName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if(finalLevel == true)
            {
                SceneManager.LoadScene(0); // Load the first level (index 0)
            }
            else
            {
                SceneManager.LoadScene(nextLevelName);
            }
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
