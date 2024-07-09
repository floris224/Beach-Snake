using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Eat : MonoBehaviour
{
    public Snake snake;
    public GameObject player, terrain;
    public SpawnFood spawnFood;
    public AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        terrain = GameObject.FindGameObjectWithTag("Ground");
        spawnFood = terrain.GetComponent<SpawnFood>();
        player = GameObject.FindGameObjectWithTag("Head");
        snake =  player.GetComponentInParent<Snake>();
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Head"))
        {

            if (snake == null)
            {
                snake = other.GetComponent<Snake>();
            }
            audioSource.Play();
            snake.AddBodyPart();
            spawnFood.isEaten = true;
           
            Destroy(gameObject);
        }
        
        
    }
}
