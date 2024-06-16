using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementManager : MonoBehaviour
{
    public AchevementDatabase database;
    public AchievementNotificationController achievementNotificationController;
    public Achevements achievementToShow;
    public void ShowNotification()
    {
        Achevement achievement = database.achevements[(int)achievementToShow];
        achievementNotificationController.showNoticification(achievement);
    }
}
