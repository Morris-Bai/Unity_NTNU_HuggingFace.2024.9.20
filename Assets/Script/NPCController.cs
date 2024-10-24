using UnityEngine;
namespace Morris
{
    /// <summary>
    /// NPC控制器
    /// </summary>
    public class NPCController : MonoBehaviour
    {
        //序列化欄位:將私人變數顯示在Unity屬性面板
        [SerializeField, Header("NPC資料")]
        private DataNPC dataNPC;

        private Animator ani;
        private void Awake()
        {
            ani = GetComponent<Animator>();
        }
    }
}