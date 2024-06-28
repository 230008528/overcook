using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrasitionStartMainMenu : MonoBehaviour
{
    public static SceneTrasitionStartMainMenu sceneController;
    [SerializeField] Animator transitionAnim;
    private void Awake() { }

   

    IEnumerator LoadMainMenu()
    {
       // transitionAnim.SetTrigger("End");
        
       // SceneManager.LoadSceneAsync("MainMenuScene");
        transitionAnim.SetTrigger("Start");
        yield return new WaitForSeconds(1);
    }
}
