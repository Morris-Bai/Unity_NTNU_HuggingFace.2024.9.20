using UnityEngine;
namespace Morris
{
    /// <summary>
    /// NPC���
    /// </summary>
    public class NPCController : MonoBehaviour
    {
        //�ǦC�����:�N�p�H�ܼ���ܦbUnity�ݩʭ��O
        [SerializeField, Header("NPC���")]
        private DataNPC dataNPC;

        private Animator ani;
        private void Awake()
        {
            ani = GetComponent<Animator>();
        }
    }
}