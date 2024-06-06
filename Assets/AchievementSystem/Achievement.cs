using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.UIElements;


public class Achievement : MonoBehaviour
{
    private string name;
    private int achievementID;
   
    void Start()
    {
            PlayerPrefs.SetString("Achievement",name);
            PlayerPrefs.SetInt("AchievementStats",0);
            PlayerPrefs.SetInt("AchievementID", achievementID);
    }
    public Achievement()
    {
        this.name=name;
        this.achievementID= achievementID;
    }
    public void SetAchievementName(string newName)
    {
        this.name=newName;
    }
    public void SetAchievementID(int newID)
    {
        this.achievementID=newID;
    }
    public string AchievementName => PlayerPrefs.GetString("Achievement");
    public int AchievementStats=>PlayerPrefs.GetInt("AchievementStats");
    public int AchievementID=>PlayerPrefs.GetInt("AchievementID");
}
