using JStudios.QuestSystem.Scripts.Interfaces;
using UnityEngine;

namespace Scenes
{
    [CreateAssetMenu(menuName = "ButtonClickRequirement")]
    public class ButtonClickRequirement : ScriptableObject, IRequirement
    {
        public int Amount;
        
        public bool IsMet()
        {
            var isMet = ButtonClickTracker.AmountOfClicks >= Amount;

            return isMet;
        }
    }
}