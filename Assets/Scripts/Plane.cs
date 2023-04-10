using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    [SerializeField]
    float velocity = 45;
    [SerializeField]
    float targetDistance = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        VisualUI.Get().OnSpawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlaneManager.Get().useMovement)
        {
            Move();
        }
    }

    Vector3 target;

    void Move()
    {

        transform.up = (target - transform.position).normalized;

        float movementAmount = velocity * Time.deltaTime;

        transform.position = transform.position + transform.up * movementAmount;

        float distance = (target - transform.position).magnitude;
        if (distance < targetDistance)
        {
            NewTarget();
        }

    }
    void NewTarget()
    {
        target = WorldBounds.Get().GetRandomPosition();
    }

    private void OnDestroy()
    {
    }
}
