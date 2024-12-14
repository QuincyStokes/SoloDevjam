using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineDetection : MonoBehaviour
{
    private GameObject outline;

    void Start()
    {
        outline = GetComponentInChildren<Outline>(true).gameObject;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            print("enabling outline");
            outline.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            outline.SetActive(false);
        }
    }
}
