using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //�������� ����������
    public AudioSource audioSource;
    //�������� ���� ���������� �� ����
    public AudioClip damageSound;
    public int score = 0;
    //�������� ������
    private int health = 10;
    //�����, ���������� �������� ������
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
        print("�������� ������: " + health);
    }

    public void GiveMoney()
    {
        score += 1;
        print("Coin: " + score);

    }
}
