using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int enemyHealth = 10;
    [SerializeField] TextMeshProUGUI myText;
    [SerializeField] GameObject prefab;
    [SerializeField] bool dropsItem = true;
    [SerializeField] bool isBoss = false;
    [SerializeField] bool isBossAlive = false;
    [SerializeField] GameObject teleporter;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player Bullet")
        {
            enemyHealth--;
            if (enemyHealth <= 0)
            {
                if (dropsItem == true)
                {
                    GameObject crate = Instantiate(prefab, transform.position, Quaternion.identity);
                }
                if (isBoss == true)
                {
                    teleporter.SetActive(true);
                    Debug.Log("foo");
                    isBossAlive = false;
                }
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player Bullet")
        {
            enemyHealth--;
            if (enemyHealth <= 0)
            {
                if (dropsItem == true)
                {
                    GameObject crate = Instantiate(prefab, transform.position, Quaternion.identity);
                }
                if (isBoss == true)
                {
                    teleporter.SetActive(true);
                    Debug.Log("foo");
                    isBossAlive = false;
                }
                Destroy(gameObject);
            }
        }
    }
 
    public bool IsBossAlive()
    {
        return isBossAlive;
    }
}
