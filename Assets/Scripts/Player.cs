using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float health = 100f;

    public float maxHealth = 100f;

    public float armor = 0f;

    public float score = 0f;



    // Use this for initialization
    void Start()
    {



    }

    private void Update()
    {
        if (health <= 0)
        {
            GameOver();
        }
    }

    public float PowerUp(float health = 10f)
    {

        this.health += health;
        return this.health;
    }

    public float ArmorPowerUp(float armor = 10f)
    {
        this.armor += armor;
        return this.armor;
    }

    public Vector2 Damage(float damage)
    {
        if (armor >= damage)
        {
            armor -= damage;
        }

        else if (armor < damage)
        {
            health -= (damage - armor);
            armor = 0;
        }

        return new Vector2(armor, health);

    }

    public float ScoreObstacle(float score = 10f)
    {
        this.score += score;
        return this.score;
    }



    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("blackObstacle"))
        {
            Damage(10f);
            Debug.Log("You've hit a blackObstacle");
        }
    }





    void GameOver()
    {
        //TODO endgame sequance
        Debug.Log("You've Died");

    }
}
