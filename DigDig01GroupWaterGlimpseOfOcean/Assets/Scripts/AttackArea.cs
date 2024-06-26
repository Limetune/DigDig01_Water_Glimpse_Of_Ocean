using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    public int damage = 3;
    private Animator animator;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<Health>() != null)
        {
            Health health = collider.GetComponent<Health>();
            health.Damage(damage);
        }
    }

}
