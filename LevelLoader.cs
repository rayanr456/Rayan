using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

   void Update()
   {
       if(Input.GetMouseButtonDown(0))
       {
            LoadNextLevel();
       }
   
    }

    public void LoadNextLevel()
    {
        //This is how you start a coroutine.
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex +1));
    }

    IEnumerator LoadLevel (int levelIndex) // This is a coroutine
    {
        //Play Animation
        transition.SetTrigger("Start");

        //Wait
        yield return new WaitForSeconds(transitionTime); //This is the weird syntax that pauses the coroutine for X amount of seconds before continuing on

        //Load Scene
        SceneManager.LoadScene(levelIndex);
    }
}
