using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonDeleter : MonoBehaviour
{
    public Animator animator;

    private int lives = 5;

    void Update()
    {   
        if (lives <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Button")
        {
            Destroy(other.gameObject);
            lives -= 1;
            animator.Play("fumble-animation");
        }
    }
}
