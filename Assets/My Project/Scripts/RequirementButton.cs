using JStudios.QuestSystem.Scripts.ScriptableObjects;
using UnityEngine;

namespace Scenes
{
    public class RequirementButton : MonoBehaviour
    {
        public void OnButtonClicked()
        {
            ButtonClickTracker.AmountOfClicks++;
            QuestSystemCore.RefreshSystem();
        }
    }
}