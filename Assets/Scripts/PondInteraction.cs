using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PondInteraction : MonoBehaviour, IInteraction
{
    public bool hasFish = false;
    [SerializeField]private float fishCooldown = 60;
    private bool isCoroutineRunning = false;
    

    //WILL ADD LITTLE BUBBLE ANIMATION OR SOMETHING LATER
    public void Interaction()
    {
        if(hasFish)
        {
            hasFish = false;
            Inventory.Instance.AddFish();
            print("Got a fish!");
        }
    }

    void Start()
    {
        if(!isCoroutineRunning)
        {
            StartCoroutine(FishCountdown());
        }
    }
    
    private IEnumerator FishCountdown()
    {   
        print("Starting fish cooldown");
        isCoroutineRunning = true;
        yield return new WaitForSeconds(fishCooldown);
        hasFish = true;
        isCoroutineRunning = false;
        print("Fish ready!");
    }

    void Update()
    {
        if(!isCoroutineRunning && hasFish == false)
        {
            StartCoroutine(FishCountdown());
        }
    }
}
