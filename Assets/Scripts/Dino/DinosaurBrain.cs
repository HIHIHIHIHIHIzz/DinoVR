using UnityEngine;

public class DinosaurBrain : MonoBehaviour
{
    public DinoState CurrentState { get; private set; }

    public void SetState(DinoState newState, string reason)
    {
        if (CurrentState == newState) return;

        Debug.Log($"[DINO] {CurrentState} → {newState} ({reason})");
        CurrentState = newState;
    }
}

