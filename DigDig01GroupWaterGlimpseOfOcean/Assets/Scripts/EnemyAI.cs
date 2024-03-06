using System.Collections;
using System.Collections.Generic;

using UnityEngine;
public class EnemyAI : MonoBehaviour
{
    public GameObject Player;
    public float speed;

    private float distance;

    private void Start()
    {

    }

    private void Update()
    {
        distance = Vector2.Distance(transform.position, Player.transform.position);
        Vector2 direction = Player.transform.position - transform.position; 
        transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);
    }
}