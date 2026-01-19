using UnityEngine;

public class PlayerFoodHolder : MonoBehaviour
{
    public bool IsHoldingFood { get; private set; }

    // 🔥 던짐 이벤트 (한 프레임용)
    public bool FoodThrownThisFrame { get; private set; }

    public void PickUpFood()
    {
        IsHoldingFood = true;
    }

    public void DropFood()
    {
        IsHoldingFood = false;
    }

    // 🔥 음식 던졌을 때 호출
    public void OnFoodThrown()
    {
        IsHoldingFood = false;
        FoodThrownThisFrame = true;
    }

    // 🔥 한 프레임짜리 이벤트라서 매 프레임 리셋
    private void LateUpdate()
    {
        FoodThrownThisFrame = false;
    }
}
