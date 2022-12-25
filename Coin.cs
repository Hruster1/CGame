using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int score;
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        player.GiveMoney();
        Destroy(gameObject);

    }
}
