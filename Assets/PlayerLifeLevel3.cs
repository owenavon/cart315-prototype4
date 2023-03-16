using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLifeLevel3 : MonoBehaviour
{
    bool dead = false; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -25f && !dead)
        {
            Die();
        }
    }

    void Die()
    {
        Invoke(nameof(ReloadLevel), 1.0f);
        dead = true; // Boolean will prevent the die function from being called over and over again.
    }

    void ReloadLevel()
    {
        if (Random.Range(0, 3) == 0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        else if (Random.Range(1, 3) == 1)
            SceneManager.LoadScene("Level 2");
        else if (Random.Range(2, 3) == 2)
            SceneManager.LoadScene("Level 1");
    }
}
