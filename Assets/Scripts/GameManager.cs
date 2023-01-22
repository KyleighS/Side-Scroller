using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //for pause menu
    public AudioSource audio;
    private float defaultPitch;
    public static GameManager Instance;
    private void Start()
    {
        if (Instance != null)
        {
            Destroy(Instance.gameObject);
        }
        else
        {
            Instance = this;
        }
    }
    public void PauseMusic()
    {
        audio.pitch = 0;
    }
    public void UnPauseMusic()
    {
        audio.pitch = defaultPitch;
    }

    //for health system
    public static GameManager gameManager { get; private set; }

    public HealthSystem _playerHealth = new HealthSystem(5,5);
 
    void Awake()
    {
        if (gameManager != null && gameManager != this)
        {
            Destroy(this);
        }
        else
        {
            gameManager = this;
        }
    }
}
