using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{
    Slider _healthSlider;

    private void Start()
    {
        _healthSlider = GetComponent<Slider>();
    }

    private void Update()
    {
        //if health is 0 then its game over
        if (_healthSlider.value == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void SetMaxHealth( int maxHealth)
    {
        _healthSlider.maxValue = maxHealth;
        _healthSlider.value = maxHealth;
    }
    public void SetHealth(int health)
    {
        _healthSlider.value = health;
    }
}
