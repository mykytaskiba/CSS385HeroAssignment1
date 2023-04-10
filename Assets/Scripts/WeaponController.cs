using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{

    [SerializeField]
    private KeyCode key;

    [SerializeField]
    private GameObject eggPrefab;

    [SerializeField]
    private float cooldown;

    float lastTimeFired = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(key))
        {
            summonProjectile();
        }

    }

    void summonProjectile()
    {
        if ((Time.time - lastTimeFired) < cooldown)
        {
            return;
        }
        lastTimeFired = Time.time;
        GameObject eggProjectile = GameObject.Instantiate(eggPrefab);
        eggProjectile.transform.position = transform.position;
        eggProjectile.transform.rotation = transform.rotation;
    }
}
