using UnityEngine;
using UnityEngine.UI;

namespace MVCExample.UnityApp
{
    public class View : MonoBehaviour
    {
        [SerializeField]
        private CounterContainer counterContainer;

        private void Awake()
        {

        }

        private void Update()
        {

        }

        private void UpdateMessage()
        {

        }

        private void OnEnable()
        {
            counterContainer.Counter.HitMaxCount += UpdateMessage;
        }

        private void OnDisable()
        {
            counterContainer.Counter.HitMaxCount -= UpdateMessage;
        }
    }
}