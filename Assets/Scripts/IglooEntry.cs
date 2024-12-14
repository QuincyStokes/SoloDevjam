using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.Rendering;

public class IglooEntry : MonoBehaviour
{
    [SerializeField]private GameObject iglooCover;
    public bool isOpaque = true;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (iglooCover != null)
            {
                if (!isOpaque)
                {
                    StartCoroutine(ChangeOpacity());
                }
                else
                {
                    StartCoroutine(ChangeOpacity());
                }
                isOpaque = !isOpaque;
            }
        }
    }

    private IEnumerator ChangeOpacity()
    {
        if(!isOpaque)
        {
            SpriteRenderer sr = iglooCover.GetComponent<SpriteRenderer>();
            for(float i = 1f; i >= .2; i-=.01f)
            {
                sr.color =  new Color(1f, 1f, 1f, i);
                yield return new WaitForSeconds(.005f);
            }
        } else
        {
             SpriteRenderer sr = iglooCover.GetComponent<SpriteRenderer>();
            for(float i = .2f; i <=1; i+=.01f)
            {
                sr.color =  new Color(1f, 1f, 1f, i);
                yield return new WaitForSeconds(.005f);
            }
        }
    }

}
