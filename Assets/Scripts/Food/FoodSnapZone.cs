using System.Collections;
using UnityEngine;

public class FoodSnapZone : MonoBehaviour
{
    public DinosaurBrain brain;
    public Transform snapTarget;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<Food>() == null) return;

        Food food = other.GetComponentInParent<Food>();

        if (brain.CurrentState == DinoState.Alert)
        {
            brain.SetState(DinoState.Angry, "경계중 먹이 급여");
            return;
        }

        /*Rigidbody rb = other.GetComponentInParent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }*/

        //other.transform.position = snapTarget.position;

        StartCoroutine(EatFlow(other.transform.parent.gameObject));
    }

    IEnumerator EatFlow(GameObject foodObj)
    {
        //yield return new WaitUntil(() => !PlayerFoodHolder.Instance.IsHoldingFood);
        yield return new WaitForSeconds(1);
        brain.SetState(DinoState.Eating, "먹이 급여");
        foodObj.transform.position = snapTarget.position;
        yield return new WaitForSeconds(5);
        foodObj.SetActive(false);
        brain.SetState(DinoState.Sleeping, "식사 완료");
    }
}
