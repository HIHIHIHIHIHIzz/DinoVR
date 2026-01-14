/*using UnityEngine;

public class DinoAnimation : MonoBehaviour
{
    public DinosaurBrain brain;
    public Animator animator;

    void Awake()
    {
        brain.OnStateChanged += HandleState;
    }

    void HandleState(DinoState state)
    {
        switch (state)
        {
            case DinoState.Watching:
                animator.SetTrigger("Look");
                break;
            case DinoState.Eating:
                animator.SetTrigger("Eat");
                break;
            case DinoState.Sleeping:
                animator.SetTrigger("Sleep");
                break;
            case DinoState.CalmReady:
                animator.SetBool("Calm", true);
                break;
        }
    }
}
*/