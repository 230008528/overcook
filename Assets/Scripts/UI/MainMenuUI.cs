using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] AchievementManager AchievementManager;
    [SerializeField] private Button playButton;
    [SerializeField] private Button quitButton;
    [SerializeField] private Button achievement;
    [SerializeField] private Button options;
    [SerializeField]private Button cSMe;
    [SerializeField]private  GameObject cSMeChar;
    [SerializeField]private GameObject youFMe;


        private void Awake()
    {
        playButton.onClick.AddListener(() =>
        {
           
           
            Loader.Load(Loader.Scene.intor_storyBG);
            
        }); 
        cSMe.onClick.AddListener(() =>
        { 
            AchievementManager.UnlockAchievement(Achevements.achG1);
            cSMe.gameObject.SetActive(false);
            cSMeChar.SetActive(false);
            youFMe.gameObject.SetActive(true);


        });
        quitButton.onClick.AddListener(() => 
        {
            Application.Quit();
        });
        achievement.onClick.AddListener(() => { SceneManager.LoadScene("Achievement"); });
        options.onClick.AddListener(() => { SceneManager.LoadScene("Options"); });

        Time.timeScale = 1f;
    }
  

}
