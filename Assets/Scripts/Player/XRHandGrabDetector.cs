using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class HandGrabDetector : MonoBehaviour
{
    public PlayerFoodHolder playerFoodHolder;

    XRDirectInteractor interactor;

    void Awake()
    {
        interactor = GetComponent<XRDirectInteractor>();
        if (interactor == null)
        {
            Debug.LogError($"❌ {gameObject.name}에 XRDirectInteractor가 없습니다!");
        }
        else
        {
            interactor.selectEntered.AddListener(OnGrab);
            interactor.selectExited.AddListener(OnRelease);
            Debug.Log("✅ 리스너 등록 완료");
        }
    }

    public void OnGrab(SelectEnterEventArgs args)
    {
        Debug.Log("🔥 OnGrab 호출됨");

        var grabbedObj = args.interactableObject.transform.gameObject;
        Debug.Log($"잡은 오브젝트: {grabbedObj.name}");

        if (grabbedObj.GetComponent<Food>() != null)
        {
            Debug.Log("✅ Food 컴포넌트 있음 → PickUpFood()");
            playerFoodHolder.PickUpFood();
        }
        else
        {
            Debug.Log("❌ Food 컴포넌트 없음");
        }
    }


    void OnRelease(SelectExitEventArgs args)
    {
        GameObject releasedObj = args.interactableObject.transform.gameObject;

        if (releasedObj.GetComponent<Food>() != null)
        {
            playerFoodHolder.DropFood();
            Debug.Log("플레이어: 음식 놓음");
        }
    }
}
