using UnityEngine;
using System.Collections;

namespace yo
{
    /// <summary>
    /// 學習協同程序, 簡稱協程 Coroutine
    /// 目的 : 讓程式停留達到等待的效果
    /// </summary>
    public class LearnCoroutine : MonoBehaviour
    {
        //使用協同程序的4個條件
        // 1. 引用命名空間 System.Collections
        // 2. 定義一個回傳 IEnumerator 的方法
        // 3. 方法內必須使用 yield return (等待)
        // 4. 使用 StartCoroutine 啟動

        //字串 : string 為 char 陣列
        private string textDialogue = "這裡好恐怖，我想要快點離開...";

        private void Awake()
        {
            //StartCoroutine(Test());

            //print("取得測試對話的第一個字" + textDialogue[0]);

            //StartCoroutine(ShowDialogue());

            StartCoroutine(ShowDialogueUseFor());
        }

        private IEnumerator Test() 
        {
            print("<color=#33ff33>第一行程式</color>");
            yield return new WaitForSeconds(2);
            print("<color=#ff3333>第二行程式</color>");
            yield return new WaitForSeconds(3);
            print("<color=#3333ff>第三行程式</color>");
        }

        private IEnumerator ShowDialogue()
        {
            print(textDialogue[0]);
            yield return new WaitForSeconds(0.1f);
            print(textDialogue[1]);
            yield return new WaitForSeconds(0.1f);
            print(textDialogue[2]);
            yield return new WaitForSeconds(0.1f);
        }

        private IEnumerator ShowDialogueUseFor()
        {
            for (int i = 0; i < textDialogue.Length; i++)
            {
                print(textDialogue[i]);
                yield return new WaitForSeconds(0.2f);
            }
        }
    }
}

