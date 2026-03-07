using Interfaces;
using UnityEngine;

public class CoinPickup : MonoBehaviour, ICollectable
{
    public void OnCollect(GameObject collector)
    {
        Debug.Log("Coin Collected");
        Destroy(gameObject);
    }
}
