using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //Звуковая переменная
    public AudioSource audioSource;
    //Звуковой файл отвечающий за урон
    public AudioClip damageSound;
    public int score = 0;
    //Здоровье игрока
    private int health = 10;
    //Метод, понижающий здоровье игрока
    public void TakeDamage(int damage)
    {
        if(health > 0)
        {
            health -= damage;
            audioSource.PlayOneShot(damageSound);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
        //health -= damage;
        print("Здоровье игрока: " + health);
    }

    public void GiveMoney()
    {
        score += 1;
        print("Coin: " + score);

    }
}
