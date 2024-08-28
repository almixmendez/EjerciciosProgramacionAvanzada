using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    private Vector2 movement;

    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(horizontal, vertical) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);    
    }
}

public class PlayerDamage : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] float damage = 1f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(damage);
        }
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Debug.Log("Player is dead!");
        }
    }
}
