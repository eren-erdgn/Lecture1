using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float _speed = 0f;
    private bool _tapToStart = false;

    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(_tapToStart == false) return;
        transform.Translate(new Vector3(0, 0, 1f) * _speed * Time.deltaTime);
        
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("ENTER PRESSED");
            GetComponent<Animator>().SetBool("RunStart", true);
            _tapToStart=true;
        }
        if(Input.GetKeyDown (KeyCode.A))
        {
            if(transform.position.x > -1)
            {
                transform.DOMoveX(transform.position.x - 1.5f, _speed * Time.deltaTime);
            }
        }
        if(Input.GetKeyDown (KeyCode.D))
        {
            if (transform.position.x < 1)
            {
                transform.DOMoveX(transform.position.x + 1.5f, _speed * Time.deltaTime);
                
            }
        }
    }
}
