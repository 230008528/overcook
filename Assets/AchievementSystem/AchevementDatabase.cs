using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Malee;

[CreateAssetMenu()]
public class AchevementDatabase : ScriptableObject
{
    [Malee.List.Reorderable]
    public List<Achevement> achevements;
    [System.Serializable]
    public class AchevementsArray<Achevement> { }
}