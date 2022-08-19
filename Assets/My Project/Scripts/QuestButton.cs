using JStudios.QuestSystem.Scripts.Behaviours;
using JStudios.QuestSystem.Scripts.ScriptableObjects.References;
using UnityEngine;

namespace Scenes
{
    public class QuestButton : MonoBehaviour
    {
        private QuestContextBehaviour _context;
        [SerializeField] private QuestSystemChannelRef _questChannel;
        
        private void Awake()
        {
            _context = this.GetComponent<QuestContextBehaviour>();
        }

        public void OnButtonClicked()
        {
            _questChannel.Ref.Progress(_context);
        }
    }
}