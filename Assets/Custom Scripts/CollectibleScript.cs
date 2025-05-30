using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    TMPro.TMP_Text text;
    int count;
    
    void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }
    
    void Start() => UpdateCount();
    
    void OnEnable() => CollectibleRotate.OnCollected += OnCollectibleCollected;
    void OnDisable() => CollectibleRotate.OnCollected -= OnCollectibleCollected;
    
    void OnCollectibleCollected()
    {
        count++;
        UpdateCount();
    }
    
    void UpdateCount()
    {
        text.text = $"{count} / {CollectibleRotate.total}";
    }
}
