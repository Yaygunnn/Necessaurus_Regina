using FMODUnity;
using UnityEngine;

namespace Audio.Events
{
    [CreateAssetMenu(fileName = "SoundEventRef", menuName = "Scriptables/SoundEvents")]
    public class EventBindingSO : ScriptableObject
    {
        [field:SerializeField] public EventReference Jump { get; private set; }
    }
}