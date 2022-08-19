using JStudios.QuestSystem.Scripts.Interfaces;
using UnityEngine;

[CreateAssetMenu(menuName = "GrantExpAction")]
public class GrantExpAction : ScriptableObject, ICompletionAction
{
    public int EXPAmount;
    
    public void Execute()
    {
        Debug.Log($"Grant {EXPAmount} EXP");
    }
}
