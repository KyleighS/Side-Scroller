using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] HealthBar _healthBar;
    //can just add emeny health hereor in an enemyBehavior script like:

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //retores some of players health
        if (collision.gameObject.tag == "Clothing")
        {
            PlayerHeal(1);
            Destroy(collision.gameObject);
            Debug.Log(GameManager.gameManager._playerHealth.Health);
        }

        //player takes damage from enemies
        if (collision.gameObject.tag == "Enemy")
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
