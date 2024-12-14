using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using JetBrains.Annotations;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Inventory : MonoBehaviour
{

    public static Inventory Instance;
    public int Logs;
    public int Fish;
    public TMP_Text fishCount;
    public TMP_Text logCount;

    void Start()
    {
        if(Instance == null)
        {
            Instance = this;
        } else
        {
            Destroy(gameObject);
        }
        Logs = 10;
        Fish = 10;
        UpdateInventory();
    }
    public void AddLog(int amount = 1)
    {
        Logs += amount;
        UpdateInventory();
    }

    public void AddFish(int amount = 1)
    {
        Fish += amount;
        UpdateInventory();
    }

    public void DeleteLog(int amount = 1)
    {
        Logs -= amount;
        UpdateInventory();
    }

    public void DeleteFish(int amount = 1)
    {
        Fish -= amount;
        UpdateInventory();
    }

    private void UpdateInventory()
    {
        fishCount.text = Fish.ToString();
        logCount.text = Logs.ToString();
    }
}
