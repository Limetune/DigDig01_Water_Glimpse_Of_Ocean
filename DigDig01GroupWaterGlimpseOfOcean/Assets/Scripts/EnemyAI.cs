using System.Collections;
using System.Collections.Generic;

using UnityEngine;
public class EnemyAI : MonoBehaviour
{
    public GameObject Player;
    public float speed;
    public float distanceBetween;

    private float distance;

    private void Start()
    {

    }

    private void Update()
    {
        distance = Vector2.Distance(transform.position, Player.transform.position);
        Vector2 direction = Player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        if (distance < distanceBetween)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }

    }



}