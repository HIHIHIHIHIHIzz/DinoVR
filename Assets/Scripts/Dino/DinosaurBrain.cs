using UnityEngine;

public class DinosaurBrain : MonoBehaviour
{
    public DinoState CurrentState { get; private set; }

    Animator animator;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    public void SetState(DinoState newState, string reason)
    {
        if (CurrentState == newState) return;

        Debug.Log($"[DINO] {CurrentState} → {newState} ({reason})");
        CurrentState = newState;

        switch (newState)
        {
            case DinoState.Alert:
                animator.SetBool("Alert", true);
                animator.SetBool("Angry", false);
                animator.SetBool("Calm", false);
                break;
            case DinoState.Angry:
                animator.SetBool("Angry", true);
                animator.SetBool("Alert", false);
                animator.SetBool("Calm", false);
                break;
            case DinoState.CalmReady:
                animator.SetBool("Calm", true);
                animator.SetBool("Angry", false);
                animator.SetBool("Alert", false);
                animator.SetBool("Eat", false);
                break;
            case DinoState.Eating:
                animator.SetBool("Eat", true);
                animator.SetBool("Angry", false);
                animator.SetBool("Calm", false);
                animator.SetBool("Alert", false);
                break;
            case DinoState.Sleeping:
                animator.SetTrigger("Sleep");
                animator.SetBool("Alert", false);
                animator.SetBool("Angry", false);
                animator.SetBool("Calm", false);
                animator.SetBool("Eat", false);
                break;
            case DinoState.Watching:
                animator.SetBool("Alert", false);
                animator.SetBool("Angry", false);
                animator.SetBool("Calm", false);
                animator.SetBool("Eat", false);
                break;
            case DinoState.Idle:
                animator.SetBool("Alert", false);
                animator.SetBool("Angry", false);
                animator.SetBool("Calm", false);
                animator.SetBool("Eat", false);
                break;
        }
    }
}

