using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class HitBuilding : MonoBehaviour
{
    public Snake snake;
    public GameObject panel;
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Hit");
        if (collision.transform.CompareTag("Building"))
        {
            panel.SetActive(false);
            snake.canvas.SetActive(true);
            snake.playerControls.Disable();
        }

    }
}
