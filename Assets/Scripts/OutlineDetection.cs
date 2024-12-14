using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;


public class OutlineDetection : MonoBehaviour
{
    private GameObject outline;
    private bool isWithin;

    private PlayerInput pi;

    void Start()
    {
        outline = GetComponentInChildren<Outline>(true).gameObject;
        pi = GetComponent<PlayerInput>();
        pi.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            print("enabling outline");
            outline.SetActive(true);
            isWithin = true;
            pi.enabled = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            outline.SetActive(false);
            isWithin = false;
            pi.enabled = false;
        }
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        if(isWithin)
        {
            GetComponent<IInteraction>().Interaction();
        }
    }

  
}
