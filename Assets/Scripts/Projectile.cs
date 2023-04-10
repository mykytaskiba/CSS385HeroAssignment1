using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float damage;

    Rigidbody2D r2d;
    // Start is called before the first frame update
    void Start()
    {
        r2d = GetComponent<Rigidbody2D>();
        VisualUI.Get().increaseEgg();
    }

    // Update is called once per frame
    void Update()
    {
        r2d.velocity = transform.up * speed;
    }

    private void OnDestroy()
    {
        VisualUI.Get().decreaseEgg();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        IDamagable damaged = collision.collider.GetComponent<IDamagable>();
        if (damaged != null)
        {
            damaged.onDamage(damage);
        }
    }
}
