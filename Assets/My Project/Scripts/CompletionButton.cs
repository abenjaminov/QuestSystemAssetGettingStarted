using System;
using JStudios.QuestSystem.Scripts.Enums;
using JStudios.QuestSystem.Scripts.ScriptableObjects.Quests;
using UnityEngine;

namespace Scenes
{
    public class CompletionButton : MonoBehaviour
    {
        public Quest QuestToComplete;

        private void Awake()
        {
            QuestToComplete.OnAvailabilityChangedEvent += OnAvailabilityChangedEvent;
        }

        private void OnDestroy()
        {
            QuestToComplete.OnAvailabilityChangedEvent -= OnAvailabilityChangedEvent;
        }

        private void OnAvailabilityChangedEvent(Quest quest)
        {
            if (!quest.IsAvailable()) return;
            
            QuestToComplete.Activate();
        }

        public void OnButtonClicked()
        {
            if (QuestToComplete.State != ActiveState.PendingCompleted) return;
            
            QuestToComplete.Complete();
        }
    }
}