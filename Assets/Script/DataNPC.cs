using UnityEngine;

namespace Morris
{
    /// <summary>
    /// NPC資料
    /// </summary>
    [CreateAssetMenu(menuName = "Morris/NPC")]

    public class DataNPC : ScriptableObject
    {
        [Header("NPC要分析的句子")]
        public string[] sentences;
    }
}