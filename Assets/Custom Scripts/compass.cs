using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject targetObject;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = transform.position + Vector3.forward;
        
        Vector3 relativeTarget = transform.parent.InverseTransformPoint(target);
        
        float needleRotation = Mathf.Atan2(relativeTarget.x, relativeTarget.z) * Mathf.Rad2Deg;
        
        transform.localRotation = Quaternion.Euler(0, needleRotation, 0);
        
    }
}
