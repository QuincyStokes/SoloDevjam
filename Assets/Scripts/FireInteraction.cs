using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireInteraction : MonoBehaviour, IInteraction
{
    public void Interaction()
    {
        if(Inventory.Instance.Logs > 0 && Fire.Instance.fireLevel < 9)
        {
            Inventory.Instance.DeleteLog();
            //increase fire strength
            Fire.Instance.AddFire(1);
        }
    }
}
