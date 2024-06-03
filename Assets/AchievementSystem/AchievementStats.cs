using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementObserver : MonoBehaviour
{
    public interface IAchievementObserver
    {
        void UpdateAchievement(Achievement achievement);
    }
    public class Achievement
    {
        public int id;
        public string name;
        public string description;
        public bool unlocked;
        private List<IAchievementObserver>observers=new List<IAchievementObserver>();
        public Achievement(int id, string name, string description)
        {
            this.id=id;
            this.name=name;
            this.description=description;
            this.unlocked=false;
        } 
        public void RegisterObserver(IAchievementObserver observer)
        {
        observers.Add(observer);
        }
        public void UnregisterObserver(IAchievementObserver observer)
        {
            observers.Remove(observer);
        } 
        private void NotifyObservers()
        {
           foreach(var observer in observers)
           {
            observer.UpdateAchievement(this);
           }
        }
        public void Unlock()
        {
            if (!unlocked)
            {
                unlocked=true;
                NotifyObservers();
            }
        }
    }
   
   
}
