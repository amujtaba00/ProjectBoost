using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody rigidbody;
    [SerializeField] float mainThrust = 1000;
    [SerializeField] float rotationThrust = 100;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
        
    }

    private void ProcessInput(){

        if (Input.GetKey(KeyCode.Space)){
            rigidbody.AddRelativeForce(Vector3.up);
        }

        if (Input.GetKey(KeyCode.A)){
            
            rigidbody.freezeRotation = true;  // Freezing rotation so we can manually rotate
            transform.Rotate(Vector3.forward);
            rigidbody.freezeRotation = false;  // Un-Freezing rotation so that the physics system takes over
            
        }
        else if (Input.GetKey(KeyCode.D)){
            
            
            rigidbody.freezeRotation = true;  // Freezing rotation so we can manually rotate
            transform.Rotate(-Vector3.forward);
            rigidbody.freezeRotation = false;  // Un-Freezing rotation so that the physics system takes over
            
        }

    }
}
