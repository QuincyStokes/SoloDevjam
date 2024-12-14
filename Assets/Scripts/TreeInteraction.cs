using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeInteraction : MonoBehaviour, IInteraction
{
    public void Interaction()
    {
        //just kill tree and give some wood? 
        Inventory.Instance.AddLog(3);
        Destroy(gameObject);
    }
}
