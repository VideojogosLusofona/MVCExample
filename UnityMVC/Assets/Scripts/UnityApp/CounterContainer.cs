using UnityEngine;
using MVCExample.Common;

namespace MVCExample.UnityApp
{
    [CreateAssetMenu(menuName = "CounterContainer")]
    public class CounterContainer : ScriptableObject
    {
        [SerializeField]
        private int maxCount = 3;

        public Counter Counter { get; private set; }

        private void OnEnable()
        {
            Counter = new Counter(maxCount);
        }
    }
}