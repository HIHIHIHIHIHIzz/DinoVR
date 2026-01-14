/*using UnityEngine;

public class DinoCalmController : MonoBehaviour
{
    public DinosaurBrain brain;
    public PlayerState playerState;

    float calmTimer;
    public float calmWaitTime = 3f;

    void Update()
    {
        if (brain.CurrentState != DinoState.Idle)
        {
            calmTimer = 0f;
            return;
        }

        if (playerState.isHoldingFood && playerState.isStill)
        {
            calmTimer += Time.deltaTime;
            if (calmTimer >= calmWaitTime)
                brain.SetState(DinoState.CalmReady);
        }
        else calmTimer = 0f;
    }
}
*/