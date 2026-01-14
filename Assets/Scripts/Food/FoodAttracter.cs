using UnityEngine;

public class FoodAttractor : MonoBehaviour
{
    public Transform feedPort;      // ∏‘¿Ã µµ¬¯ ¡ˆ¡°
    public float attractSpeed = 4f; // »Ì¿‘ º”µµ

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Food")) return;

        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.useGravity = false;
            rb.isKinematic = true;
        }

        other.GetComponent<Food>()?.StartAttract(feedPort, attractSpeed);
    }
}
