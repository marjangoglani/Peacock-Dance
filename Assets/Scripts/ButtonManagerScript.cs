using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManagerScript : MonoBehaviour
{
    public GameObject RightTarget;
    public GameObject LeftTarget;
    public GameObject UpTarget;
    public GameObject DownTarget;

    private GameObject RightButton;
    private GameObject LeftButton;
    private GameObject UpButton;
    private GameObject DownButton;

    private float distance;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            RightButton = GameObject.Find("RightArrow(Clone)");
            if (RightButton != null)
            {
                distance = Mathf.Abs(RightButton.transform.position.y - RightTarget.transform.position.y);
                if (distance < 2)
                {
                    Destroy(RightButton);
                }
            }

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            LeftButton = GameObject.Find("LeftArrow(Clone)");
            if (LeftButton != null)
            {
                distance = Mathf.Abs(LeftButton.transform.position.y - LeftTarget.transform.position.y);
                if (distance < 2)
                {
                    Destroy(LeftButton);
                }
            }

        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            UpButton = GameObject.Find("UpArrow(Clone)");
            if (UpButton != null)
            {
                distance = Mathf.Abs(UpButton.transform.position.y - UpTarget.transform.position.y);
                if (distance < 2)
                {
                    Destroy(UpButton);
                }
            }

        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            DownButton = GameObject.Find("DownArrow(Clone)");
            if (DownButton != null)
            {
                distance = Mathf.Abs(DownButton.transform.position.y - DownTarget.transform.position.y);
                if (distance < 2)
                {
                    Destroy(DownButton);
                }
            }

        }
    }
}
