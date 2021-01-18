using UnityEngine;

namespace MVCExample.UnityApp
{
    public class Controller : MonoBehaviour
    {
        [SerializeField]
        private CounterContainer counterContainer;

        public void IncrementAction()
        {
            counterContainer.Counter.IncrementCount();
        }

        public void Quit()
        {
#if UNITY_STANDALONE
            Application.Quit();
#endif

#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }
    }
}