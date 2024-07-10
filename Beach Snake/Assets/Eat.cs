using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
public class Eat : MonoBehaviour
{
    public Snake snake;
    public GameObject player, terrain,soundManager;
    public SpawnFood spawnFood;
    public AudioSource audioSource;
    public bool boom;
    public AudioClip audioclip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        soundManager = GameObject.FindGameObjectWithTag("SoundManager");
        audioSource = soundManager .GetComponent<AudioSource>();
      
        terrain = GameObject.FindGameObjectWithTag("Ground");
        spawnFood = terrain.GetComponent<SpawnFood>();
        player = GameObject.FindGameObjectWithTag("Head");
        snake =  player.GetComponentInParent<Snake>();
       
    }
    public void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Head"))
        {
            
            if (snake == null)
            {
                snake = other.GetComponent<Snake>();
            }
            audioSource.PlayOneShot(audioclip);
            snake.AddBodyPart();
            spawnFood.isEaten = true;
            boom = true;  
            Destroy(gameObject);
        }
        
        
    }
    
}
