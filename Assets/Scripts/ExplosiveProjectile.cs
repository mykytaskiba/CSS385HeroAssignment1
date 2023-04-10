using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveProjectile : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    int quantity;

    [SerializeField]
    float spreadFactor;

    void summon()
    {
        for (int i = 0; i < quantity; i++)
        {
            GameObject instance = GameObject.Instantiate(prefab);
            instance.transform.position = transform.position;

            float percentage = (float) i / quantity;
            instance.transform.rotation = Quaternion.Euler(0, 0, 360f * percentage);

            instance.transform.position = instance.transform.position + instance.transform.up * spreadFactor;
        }
    }

    private void OnDestroy()
    {
        summon();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
