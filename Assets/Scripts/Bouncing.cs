using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!WorldBounds.Get().WithinBounds(transform.position))
        {
            Vector3 direction = (WorldBounds.Get().GetRandomPosition() - transform.position);
            direction = direction.normalized;
            transform.up = direction;
        }

    }
}
