using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        // Get the current active scene
        Scene currentScene = SceneManager.GetActiveScene();
        // Calculate the next scene index
        int nextSceneIndex = currentScene.buildIndex + 1;

        // Check if the next scene index is within the valid range
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            Debug.Log("No more scenes to load!");
        }
    }
    
    public void LoadLastScene()
    {
        // Get the current active scene
        Scene currentScene = SceneManager.GetActiveScene();
        // Calculate the next scene index
        int lastSceneIndex = currentScene.buildIndex - 1;
        SceneManager.LoadScene(lastSceneIndex);

        //// Check if the next scene index is within the valid range
        //if (lastSceneIndex > SceneManager.sceneCountInBuildSettings)
        //{
            
        //}
        //else
        //{
        //    Debug.Log("No more scenes to load!");
        //}
    }

    public void Quit()
    {
        Application.Quit();
    }

}
