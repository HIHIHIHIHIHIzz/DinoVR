/*using UnityEngine;

public class DinoAlertZoneTrigger : MonoBehaviour
{
    public DinoAlertController alertController;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("player inside alertzone");
        if (!other.CompareTag("Player")) return;
        alertController.EnterAlert();
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        alertController.ExitAlert();
    }
}
*/
