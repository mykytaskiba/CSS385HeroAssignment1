using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed;

    float angle = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotationInput = 0;
        if (Input.GetKey(KeyCode.A))
        {
            rotationInput += 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rotationInput += -1;
        }

        float rotationAmount = rotationInput * Time.deltaTime * rotationSpeed;
        angle += rotationAmount;

        transform.rotation = Quaternion.Euler(0, 0, angle);

    }
}
