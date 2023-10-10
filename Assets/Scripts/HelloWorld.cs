using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    [SerializeField] private Vector3 _first;
    [SerializeField] private Vector3 _second;
    // Start is called before the first frame update
    void Start()
    {
        Debug.DrawLine(_first, _second, Color.red, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
