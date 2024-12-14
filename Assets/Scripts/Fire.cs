using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public float fireLevel = 5f;
    private float MAX_FIRE = 10f;
   
    [SerializeField] private GameObject temperatureUI;

    public static Fire Instance;

    void Start()
    {
        if(Instance == null)
        {
            Instance = this;
        } else
        {
            Destroy(gameObject);
        }
        UpdateTemperatureScale();
    }

    void Update()
    {   
        SubtractFire(.0003f);
        UpdateTemperatureScale();
        
    }
   

    public void AddFire(int amount)
    {

        fireLevel += amount;
        if(fireLevel > MAX_FIRE)
        {
            fireLevel = MAX_FIRE;
        }
        UpdateTemperatureScale();
        
    }

    public void SubtractFire(float amount)
    {
        fireLevel -= amount;
        UpdateTemperatureScale();
        if(fireLevel <= 0)
        {
            print("Game Over");
        }
    }

    private void UpdateTemperatureScale()
    {
        temperatureUI.transform.localScale = new Vector3(temperatureUI.transform.localScale.x, fireLevel/MAX_FIRE, 0);
    }

    
    
}
