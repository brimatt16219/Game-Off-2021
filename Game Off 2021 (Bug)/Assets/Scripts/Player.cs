using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;

    public int health;
    public int maxHealth = 20;

    private Vector3 change;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");

        Move();
    }

    void Move()
    {
        rb.MovePosition(transform.position + change.normalized * speed * Time.deltaTime);
        
    }
    
    void TakeDamage(int damage)
    {
        health -= damage;
        healthBar.SetHealth(health);
    }
}
