using UnityEngine;

public class FoodSnapZone : MonoBehaviour
{
    public DinosaurBrain brain;
    public Transform snapTarget;

    private void OnTriggerEnter(Collider other)
    {
        // �������� Ȯ��
        Food food = other.GetComponent<Food>();
        if (food == null) return;

        // ��� ���¿����� �۵�
        if (brain.CurrentState != DinoState.Alert) return;

        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

        other.transform.position = snapTarget.position;

        brain.SetState(DinoState.Angry, "��� �� ���� ���� ����");
    }
}
