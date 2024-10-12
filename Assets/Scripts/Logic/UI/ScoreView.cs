using TMPro;
using UnityEngine;

namespace Assets.Scripts.Logic.UI
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _text;

        public void UpdateText(string text) =>
            _text.text = text;
    }
}