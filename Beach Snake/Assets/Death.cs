using UnityEngine;

public class Death : MonoBehaviour
{
    public Snake snake;
    public GameObject panel;
    private void Awake()
    {
        snake = GetComponentInParent<Snake>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Head"))
        {
            panel.SetActive(false);
            snake.canvas.SetActive(true);
            snake.playerControls.Disable();
        }
    }
}
