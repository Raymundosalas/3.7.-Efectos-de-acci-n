using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 10f;
    public float lifeTime = 5f;
    public GameObject explosionEffect;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Destruir el misil después de cierto tiempo
        Destroy(gameObject, lifeTime);
    }

    void FixedUpdate()
    {
        // Movimiento hacia adelante
        rb.linearVelocity = transform.right * speed;
    }

    void Update()
    {
        // Rotación automática según la velocidad
        if (rb.linearVelocity != Vector2.zero)
        {
            float angle = Mathf.Atan2(rb.linearVelocity.y, rb.linearVelocity.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Explode();
    }

    void Explode()
    {
        if (explosionEffect != null)
        {
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
        }

        Destroy(gameObject);
    }
}
