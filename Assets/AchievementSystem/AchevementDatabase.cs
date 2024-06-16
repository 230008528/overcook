using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Malee;
using Malee.List;

[CreateAssetMenu()]
public class AchevementDatabase : ScriptableObject
{
    [Malee.List.Reorderable]
    public List<Achevement> achevements;
    [System.Serializable]
    public class AchevementsArray : ReorderableArray<Achevement> { }
}