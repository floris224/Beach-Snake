using UnityEngine;
using TMPro;
public class Death : MonoBehaviour
{
    public TMP_Text text;
    public Snake snake;
    public GameObject panel, parentSnake;
    private void Awake()
    {
      
        parentSnake = GameObject.FindGameObjectWithTag("Main");
        snake = parentSnake.GetComponent<Snake>();

        panel = GameObject.FindGameObjectWithTag("Panel");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Head"))
        {
            panel.SetActive(false);
            snake.canvas.SetActive(true);
            snake.playerControls.Disable();
            snake.speed = 0;
            text.text = "Score : " + snake.score.ToString(); 
        }
    }
}
