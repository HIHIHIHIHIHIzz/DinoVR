using UnityEngine;

public class PlayerState : MonoBehaviour
{
    public bool isHoldingFood = false;
    public bool isStill = true;

    private Vector3 lastPos;

    void Start()
    {
        lastPos = transform.position;
    }

    void Update()
    {
        isStill = Vector3.Distance(transform.position, lastPos) < 0.01f;
        lastPos = transform.position;
    }

    // 먹이 집었을 때
    public void HoldFood(bool value)
    {
        isHoldingFood = value;
    }
}

