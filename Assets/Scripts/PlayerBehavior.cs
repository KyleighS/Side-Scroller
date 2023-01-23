using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] HealthBar _healthBar;
    //can just add emeny health hereor in an enemyBehavior script like:
    //public HealthSystem _playerHealth = new HealthSystem(5,5);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Clothing")
        {
            PlayerHeal(1);
            Destroy(collision.gameObject);
            Debug.Log(GameManager.gameManager._playerHealth.Health);
        }
    }

    void Update()
    {
        //where to put the damage taken if a player collides with an enemy
        //and prob where to put heal from itemss

        if(Input.GetKeyDown(KeyCode.C))
        {
            PlayerTakesDamg(2);
            Debug.Log(GameManager.gameManager._playerHealth.Health);
        }
   
    }


    private void PlayerTakesDamg(int damg)
    {
        GameManager.gameManager._playerHealth.DamgUnit(damg);
        _healthBar.SetHealth(GameManager.gameManager._playerHealth.Health);
    }
    private void PlayerHeal(int healing)
    {
        GameManager.gameManager._playerHealth.HealUnit(healing);
        _healthBar.SetHealth(GameManager.gameManager._playerHealth.Health);
    }
}
