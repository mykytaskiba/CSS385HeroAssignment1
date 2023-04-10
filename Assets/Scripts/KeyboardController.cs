using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : MonoBehaviour
{


    [SerializeField]
    private float initialVelocity;

    [SerializeField]
    private float accelaration;

    float velocity;
    
    // Start is called before the first frame update
    void Start()
    {
        velocity = initialVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        float velocityInput = 0;
        if (Input.GetKey(KeyCode.W))
        {
            velocityInput += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocityInput += -1;
        }

        velocity += accelaration * velocityInput * Time.deltaTime;

        float movementAmount = velocity * Time.deltaTime;

        transform.position = transform.position + transform.up * movementAmount;
        
    }
}
