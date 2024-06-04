using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
 

public class AchievementObserver : MonoBehaviour
{ 
  public bool unlocked = false;
  public int detector=0;
  public int counterOfAD;
  public int counterOfA;
    public void addcounterA()
    {
       counterOfA=counterOfAD+1;
    }
    public void addcounterOfAD() {
       counterOfAD=counterOfAD+1; 
    }

    public bool AFinished()
    {
        unlocked= true;
        return unlocked;
    }
    public void  FinishedOver()
    {
        unlocked= false;
    }
    public void ADector(int n)
    {
        detector=n;
       
    }
    public int getDector()
    {
        return detector;
    }
    public void returnToNomal()
    {
        detector=0;
    }

}
