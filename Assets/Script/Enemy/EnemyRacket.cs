using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRacket : MonoBehaviour
{
    Rigidbody2D enemy;

    [Header("NPC Settings")]
    public float speed, delaymove;
    private bool isMoveEnemy, isSingleTake, isUp;
    private float randomPos;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!isMoveEnemy && !isSingleTake)
        {
            StartCoroutine("delayEnemyMove");
            isSingleTake = true;
        }

        if (isMoveEnemy)
        {
            moveEnemy();
        }
        
    }
    private IEnumerator delayEnemyMove()
    {
        yield return new WaitForSeconds(delaymove);
        randomPos = Random.Range(-1f, 1f);
        if (transform.position.y < randomPos)
        {
            isUp = true;
        }
        else    if (transform.position.y > randomPos)
        {
            isUp = false;
        }
        isSingleTake = false;
        isMoveEnemy = true;
    }
    private void moveEnemy()
    {
        if (!isUp)
        {
            enemy.velocity = new Vector2(0, -1) * speed;
            if(transform.position.y <= randomPos)
            {
                enemy.velocity = Vector2.zero;
                isMoveEnemy = false;
            }
        }
        if (isUp)
        {
            enemy.velocity = new Vector2(0, 1) * speed;
            if (transform.position.y >= randomPos)
            {
                enemy.velocity = Vector2.zero;
                isMoveEnemy = false;
            }
        }
    }
}
