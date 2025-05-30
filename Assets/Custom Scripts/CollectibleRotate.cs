using System;
using UnityEngine;

public class CollectibleRotate : MonoBehaviour
{
    public static event Action OnCollected;
    public static int total;
    
    
    void Awake() => total++;
    
    void Update()
    {
        transform.localRotation = Quaternion.Euler(0f, Time.time * 100f, 0);
    }
    
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            OnCollected?.Invoke();
            Destroy(gameObject);
        }
    }
}
