using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public float MaxHealth;

    public UnityEvent OnTakeDamage;
    public UnityEvent OnDead;

<<<<<<< HEAD
    public float currentHealth;
=======
    private float currentHealth;
>>>>>>> 5f5fc35a554c643ae90d9aa19fe6370c73aee576

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(float damageAmount)
    {
        if (!IsDead())
        {
            OnTakeDamage?.Invoke();
            currentHealth -= damageAmount;
            print($"{currentHealth}");
            
            if (IsDead())
            {
                OnDead?.Invoke();
            }
        }
    }

    public bool IsDead()
    {
        return currentHealth <= 0;
    }
}
