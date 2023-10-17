using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    float _increaseRotValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _increaseRotValue += 0.1f;
        transform.localRotation =
            Quaternion.Euler(0f, 0f, 0f + _increaseRotValue);
    }
}
