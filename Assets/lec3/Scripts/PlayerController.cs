using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]private float _runSpeed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private Projectile projectile;
    [SerializeField] private Transform spawnPosition;
    private Rigidbody _rb;
    private Camera _camera;


    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(projectile, spawnPosition.position,spawnPosition.rotation);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * _runSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * _runSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * _runSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * _runSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(Vector3.up * _jumpForce * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftShift))
        {
            _camera.transform.localPosition = new Vector3(0f, -0.5f, 0f);
        }
        else
        {
            _camera.transform.localPosition = new Vector3(0f, 0.5f, 0f);
        }
            

    }
}
