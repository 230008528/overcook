using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementManager : MonoBehaviour
{
    public AchevementDatabase database;
    public AchievementNotificationController achievementNotificationController;
    public DownDownController achievementDropDownController;
    

    public GameObject achievementItemPrefab;
    public Transform content;

    [SerializeField] [HideInInspector]
    private List<AchievementItemControler> achievementItems;

    public Achevements achievementToShow;
    private void Start()
    {
        achievementDropDownController.onValueChanged+=HandleAchievementDropdownValueChanged;
        LoadAchievementsTable();
    }
    public void ShowNotification()
    {
        Achevement achievement = database.achevements[(int)achievementToShow];
        achievementNotificationController.showNoticification(achievement);
    }
    private void HandleAchievementDropdownValueChanged(Achevements achevement)
    {
        achievementToShow=achevement;
    }
    [ContextMenu("LoadAchievementsTable()")]
    private void LoadAchievementsTable()
    {
        foreach(AchievementItemControler controller in achievementItems)
        {
            DestroyImmediate(controller.gameObject);
        }
        achievementItems.Clear();
        foreach(Achevement achevement in database.achevements)
        {
            GameObject obj=Instantiate(achievementItemPrefab,content );
            AchievementItemControler controller =obj.GetComponent<AchievementItemControler>();
            controller.achievement=achevement;
            controller.RefreshView();
            achievementItems.Add(controller);
        }
    }
    public void UnlockAchievement()
    {
        UnlockAchievement(achievementToShow);
    }
    public void UnlockAchievement(Achevements achievement)
    {
        AchievementItemControler item = achievementItems[(int)achievement];
        if(item.unlocked)  return;

        ShowNotification();
        PlayerPrefs.SetInt(item.achievement.id,1);
        item.unlocked =true;
        item.RefreshView();
    }
}
