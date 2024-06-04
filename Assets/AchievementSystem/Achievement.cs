using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.UIElements;

public class AchievementData
{
    public string name;
    public int id;
}
public class Achievement : PopupField<AchievementData>
{
    public Achievement()
    {
        formatSelectedValueCallback=FormatItem;
        formatListItemCallback = FormatItem;
        choices = new List<AchievementData>{
            new AchievementData { name = "Overcook!", id = 1 },
            new AchievementData { name = "......", id = 2 },
            new AchievementData { name = "Waiter...help..", id = 3 },
        };

    }
    static string FormatItem(AchievementData data)
    {
        return data.name;
    }
}
