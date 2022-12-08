using UnityEngine;

namespace yo
{
    /// <summary>
    /// 對話資料
    /// </summary> 
    [CreateAssetMenu(menuName = "YO/Dialogue Data", fileName ="New Dialogue Data")]
    public class DialogueData : ScriptableObject
    {
        [Header("對話者名稱")]
        public string dialogueName;
        [Header("對話者內容"), TextArea(2,10)]
        public string[] dialogueContents;
    }
}

