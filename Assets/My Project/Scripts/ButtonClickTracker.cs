using UnityEngine;

namespace Scenes
{
    public static class ButtonClickTracker
    {
        public static int AmountOfClicks { get; set; }
        
        static ButtonClickTracker()
        {
            AmountOfClicks = 0;
            Debug.Log(AmountOfClicks);
        }
    }
}