using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 2;
    int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

  public void TakeDamg(int damg)
    {
        currentHealth -= damg;
        animator.SetTrigger("Hurt");

        if (currentHealth < 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Emeny has died");
        animator.SetBool("isDead", true);

        //will disable enimies
        Destroy(gameObject);

    }
}
