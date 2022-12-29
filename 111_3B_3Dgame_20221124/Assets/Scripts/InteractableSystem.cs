using UnityEngine;
using UnityEngine.Events;

namespace yo
{
    /// <summary>
    /// 互動系統：偵測玩家是否進入觸發區域並處理互動行為
    /// </summary>
    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField, Header("第一段的對話資料")]
        private DialogueData dataDialogue;
        [SerializeField, Header("結束對話後的事件")]
        private UnityEvent onDialogueFinish;    //Unity 事件

        [SerializeField, Header("啟動道具")]
        private GameObject propActive;
        [SerializeField, Header("啟動後的對話資料")]
        private DialogueData dataDialogueActive;
        [SerializeField, Header("啟動結束對話後的事件")]
        private UnityEvent onDialogueFinishAfterActive;

        private string nameTarget = "PlayerCapsule";
        private DialogueSystem dialogueSystem;

        private void Awake()
        {
            dialogueSystem = GameObject.Find("畫布對話系統").GetComponent<DialogueSystem>();
        }

        // 兩個碰撞物件碰撞
        // 其中一個有勾選 Is Trigger
        //觸發開始
        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains(nameTarget))
            {
                // 如果 不需要啟動道具 或者 啟動道具是顯示的 (未獲得) 就執行 第一段對話
                if (propActive == null || propActive.activeInHierarchy)
                {
                    dialogueSystem.StartDialogue(dataDialogue, onDialogueFinish);
                }
                else
                    dialogueSystem.StartDialogue(dataDialogueActive, onDialogueFinishAfterActive);
            }
        }
        //觸發離開
        private void OnTriggerExit(Collider other)
        {

        }
        //觸發持續
        private void OnTriggerStay(Collider other)
        {

        }

        /// <summary>
        /// 隱藏物件
        /// </summary>
        public void HiddenObject()
        {
            gameObject.SetActive(false);
        }
    }
}
