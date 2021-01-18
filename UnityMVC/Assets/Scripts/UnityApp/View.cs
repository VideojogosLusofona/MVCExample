using UnityEngine;
using UnityEngine.UI;

namespace MVCExample.UnityApp
{
    public class View : MonoBehaviour
    {
        [SerializeField]
        private CounterContainer counterContainer;

        [SerializeField]
        private float textVanishDuration = 1.0f;

        private Text text;
        private float lastTextTime = float.NegativeInfinity;

        private readonly Color baseColor = Color.red;
        private readonly Color noColor = new Color(1, 0, 0, 0);

        private void Awake()
        {
            GameObject message = GameObject.Find("Message");
            text = message.GetComponent<Text>();
            text.color = noColor;
        }

        private void Update()
        {
            float timeLeftToVanish =
                lastTextTime + textVanishDuration - Time.time;
            if (timeLeftToVanish > 0)
            {
                float t = timeLeftToVanish / textVanishDuration;
                text.color = Color.Lerp(noColor, baseColor, t);
            }
        }

        private void UpdateMessage()
        {
            lastTextTime = Time.time;
            Debug.Log("Hit max count!");
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