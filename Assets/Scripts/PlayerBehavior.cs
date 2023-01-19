using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
 
    void Start()
    {
        
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
        if (Input.GetKeyDown(KeyCode.H))
        {
            PlayerHeal(1);
            Debug.Log(GameManager.gameManager._playerHealth.Health);
        }
    }

    private void PlayerTakesDamg(int damg)
    {
        GameManager.gameManager._playerHealth.DamgUnit(damg);
    }
    private void PlayerHeal(int healing)
    {
        GameManager.gameManager._playerHealth.HealUnit(healing);
    }
}
