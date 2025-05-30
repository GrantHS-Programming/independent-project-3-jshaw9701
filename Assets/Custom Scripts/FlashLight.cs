using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    public GameObject light;
    
    void Update() 
    {
        if(Input.GetMouseButtonDown(1))
        {
            light.SetActive(true);
        }
        if(Input.GetMouseButtonUp(1))
        {
            light.SetActive(false);
        }
    }
}