using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldBounds : MonoBehaviour
{

    //Singleton
    static WorldBounds instance;
    public static WorldBounds Get()
    {
        return instance;
    }

    private void Awake()
    {
        instance = this;
    }

    [SerializeField]
    float spawnBoundsRange = 0.9f;

    public bool WithinBounds(Vector3 position)
    {
        Vector3 pos = Camera.main.WorldToViewportPoint(position);

        if (pos.x < 0 || pos.x > 1)
        {
            return false;
        }
        if (pos.y < 0 || pos.y > 1)
        {
            return false;
        }

        return true;
    }

    public Vector3 GetRandomPosition()
    {
        float outerBorder = (1 - spawnBoundsRange) / 2f;

        float randX = outerBorder + (Random.value) * spawnBoundsRange;
        float randY = outerBorder + (Random.value) * spawnBoundsRange;
        Vector3 position = new Vector3(randX, randY, 0);

        Vector3 result = Camera.main.ViewportToWorldPoint(position);
        result.z = 0;
        return result;

    }
}
