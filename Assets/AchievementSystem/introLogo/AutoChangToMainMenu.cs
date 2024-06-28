using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoChangToMainMenu : MonoBehaviour
{
    public static AutoChangToMainMenu sceneController;
    [SerializeField] Animator transitionAnim;
    private void Awake() { }

    public void StartMainMenu()
    {
        StartCoroutine(LoadMainMenu());
        // SceneManager.LoadSceneAsync("MainMenuScene");
    }

   IEnumerator LoadMainMenu()
    {
        transitionAnim.SetTrigger("End");
        yield return new WaitForSeconds(1);
        SceneManager.LoadSceneAsync("MainMenuScene");
        //transitionAnim.SetTrigger("Start");
    }


}
