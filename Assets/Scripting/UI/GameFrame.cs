using UnityEngine;
using UnityEngine.UI;

namespace MathGame.UI
{
    public class GameFrame : MonoBehaviour
    {
        [SerializeField] private FrameAssetHolder _frameAssetHolder;
        [SerializeField] private Image _frameImageComponent;

        private void OnEnable()
        {
            BindEvents();
        }

        private void OnDisable()
        {
            UnbindEvents();
        }

        private void BindEvents()
        {
            GameActions.CorrectAnswer += ChangeFrameForGoodAnswer;
            GameActions.WrongAnswer += ChangeFrameForWrongAnswer;
            GameActions.GeneratorReset += ResetFrame;
        }

        private void UnbindEvents()
        {
            GameActions.CorrectAnswer -= ChangeFrameForGoodAnswer;
            GameActions.WrongAnswer -= ChangeFrameForWrongAnswer;
            GameActions.GeneratorReset -= ResetFrame;
        }

        private void Start()
        {
            ResetFrame();
        }

        private void ChangeFrameForGoodAnswer()
        {
            _frameImageComponent.sprite = _frameAssetHolder.GreenFrameAsset;
        }

        private void ChangeFrameForWrongAnswer()
        {
            _frameImageComponent.sprite = _frameAssetHolder.RedFrameAsset;
        }

        private void ResetFrame()
        {
            _frameImageComponent.sprite = _frameAssetHolder.DefaultFrameAsset;
        }
    }
}