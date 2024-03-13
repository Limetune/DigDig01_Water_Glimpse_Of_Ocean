using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int health = 100;

    private int MAX_HEALTH = 100;
    void Start()
    {
        
    }

    public void Damage(int amount)
    {
      if(amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Varf�r tror du att spelet kan ha negativ health?");
        }
        this.health -= amount;
        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Death logic here

        Debug.Log("Dead");
        Destroy(GameObject.FindWithTag("Enemy"));

    }
}
