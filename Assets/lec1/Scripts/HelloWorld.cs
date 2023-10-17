using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    [SerializeField] private Transform _first;
    [SerializeField] private Transform _second;
    Vector3 _firstPoint;
    Vector3 _secondPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _firstPoint = _first.position;
        _secondPoint = _second.position;
        Debug.DrawLine(_firstPoint, _secondPoint, Color.red);
    }
}
