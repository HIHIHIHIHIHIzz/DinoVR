using UnityEngine;

public class DinoAlertTrigger : MonoBehaviour
{
    [Header("References")]
    public DinosaurBrain brain;

    PlayerFoodHolder playerFood;

    [Header("Alert Condition")]
    bool playerInside;

    [Header("Alert Exit")]
    public float calmDuration = 3f;
    float calmTimer = 0f;

    void Update()
    {
        // 1️⃣ Idle → Alert (음식이 '경계 트리거')
        if (brain.CurrentState == DinoState.Idle)
        {
            if (playerInside &&
                playerFood != null &&
                playerFood.IsHoldingFood)
            {
                brain.SetState(DinoState.Alert, "음식 들고 접근");
            }
        }

        // Alert 상태가 아니면 아래 로직은 안 봄
        if (brain.CurrentState != DinoState.Alert) return;

        // 2️⃣ Alert → Angry (경계 중 음식 던짐)
        if (playerFood != null && playerFood.FoodThrownThisFrame)
        {
            brain.SetState(DinoState.Angry, "경계 중 음식 투척");
            return;
        }

        // 3️⃣ Alert 유지 / 해제 판단
        // 음식 여부 ❌ / 거리만 본다
        if (!playerInside)
        {
            calmTimer += Time.deltaTime;

            if (calmTimer >= calmDuration)
            {
                brain.SetState(DinoState.Idle, "거리 확보로 경계 해소");
                calmTimer = 0f;
            }
        }
        else
        {
            // 다시 다가오면 타이머 초기화
            calmTimer = 0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // VR 구조 대응: 부모에서 PlayerFoodHolder 탐색
        var foodHolder = other.GetComponentInParent<PlayerFoodHolder>();
        if (foodHolder == null) return;

        playerInside = true;
        playerFood = foodHolder;
    }

    private void OnTriggerExit(Collider other)
    {
        var foodHolder = other.GetComponentInParent<PlayerFoodHolder>();
        if (foodHolder == null) return;

        playerInside = false;
        calmTimer = 0f;
    }
}

