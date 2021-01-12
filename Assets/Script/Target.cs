using UnityEngine;

public class Target : MonoBehaviour
{
    public float healf = 50f;
    
    public void TakeDamage(float amout)
    {
        healf -= amout;
        if (healf <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        
        Destroy(gameObject);
    }
}
