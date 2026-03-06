using UnityEngine;

public class HealthPickup : MonoBehaviour, ICollectable
{
    [SerializeField] private int healAmount = 1;

    public void OnCollect(GameObject collector)
    {
        Health health = collector.GetComponent<Health>();

        if (health != null)
        {
            Debug.Log("Health Collected: " + healAmount);
            health.Heal(healAmount);
        }

        Destroy(gameObject);
    }
}
