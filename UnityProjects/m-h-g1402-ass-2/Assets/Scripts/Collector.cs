using UnityEngine;

public class Collector : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        ICollectable otherCollectable = other.GetComponent<ICollectable>();

        if (otherCollectable != null)
        {
            otherCollectable.OnCollect();
        }
    }
}
