using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDeleter : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Button")
        {
            Destroy(other.gameObject);
            Debug.Log("collision");
        }
    }
}
