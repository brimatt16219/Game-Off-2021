using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Interacting { INTERACTING, NOTINTERACTING }

public class Player : MonoBehaviour
{
    public Interacting interact;

    public float speed;

    private Rigidbody2D rb;

    public int health;
    public int maxHealth = 20;

    private Vector3 change;

    //public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        health = maxHealth;
        //healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");

        if (interact == Interacting.NOTINTERACTING)
            Move();
    }

    void Move()
    {
        rb.MovePosition(transform.position + change.normalized * speed * Time.deltaTime);
        
    }

    void UpdateHealth()
    {
        
    }
    
    void TakeDamage(int damage)
    {
        health -= damage;
        //healthBar.SetHealth(health);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Interactable"))
        {
            //interact = Interacting.INTERACTING;
        }
    }
}
