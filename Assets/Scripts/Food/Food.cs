using UnityEngine;

public class Food : MonoBehaviour
{
    private Transform target;
    private float speed;
    private bool isAttracting = false;

    public void StartAttract(Transform targetPort, float attractSpeed)
    {
        target = targetPort;
        speed = attractSpeed;
        isAttracting = true;
    }

    void Update()
    {
        if (!isAttracting || target == null) return;

        transform.position = Vector3.MoveTowards(
            transform.position,
            target.position,
            speed * Time.deltaTime
        );
    }
}
