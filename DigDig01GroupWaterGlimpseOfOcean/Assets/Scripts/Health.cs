using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void Damage(int amount)
    {
      if(amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Varför tror du att spelet kan ha negativ health?");
        }
        this.currentHealth -= amount;
    }

    void Die()
    {
        // Death logic here
        Destroy(gameObject);
    }
}
