using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public CanvasGroup myCanvasGroup; // Reference to your Canvas Group or other UI element

    private void OnTriggerStay2D(Collider2D other)
    {
        // Check if the colliding object is the player
        if (other.name=="Player")
        {
            // Show the UI
            ShowUI();
        }
    }

    void ShowUI()
    {
        myCanvasGroup.alpha = 1; // Show the UI
        // You can add additional logic here if needed
    }
}


