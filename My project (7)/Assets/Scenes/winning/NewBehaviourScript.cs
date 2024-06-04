using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public CanvasGroup myCanvasGroup; // Reference to your Canvas Group or other UI element

    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object is the player
        if (other.name=="Player")
        {
            // Hide the UI
            HideUI();
        }
    }

    void HideUI()
    {
        myCanvasGroup.alpha = 0; // Hide the UI
        // You can add additional logic here if needed
    }
}
