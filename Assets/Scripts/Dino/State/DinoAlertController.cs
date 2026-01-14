/*using UnityEngine;

public class DinoAlertController : MonoBehaviour
{
    public DinosaurBrain brain;
    public Animator animator;

    float timer;
    bool strongPhase = true;

    public void EnterAlert()
    {
        brain.SetState(DinoState.Alert);

        animator.SetBool("Alert", true);
        animator.SetFloat("AlertLevel", 1.2f);
        

        timer = 0f;
        strongPhase = true;
        Debug.Log("[ALERT] EnterAlert ¡æ STRONG (AlertLevel = 1.2)", this);
    }

    void Update()
    {
        if (brain.CurrentState != DinoState.Alert) return;

        timer += Time.deltaTime;

        if (strongPhase && timer > 2f)
        {       
            animator.SetFloat("AlertLevel", 0.8f);
            strongPhase = false;

            Debug.Log("[ALERT] Switched to WEAK (AlertLevel = 0.8)", this);
        }
    }

    public void ExitAlert()
    {
        animator.SetBool("Alert", false);
        animator.SetFloat("AlertLevel", 1f);

        brain.SetState(DinoState.Idle);
    }
}

*/