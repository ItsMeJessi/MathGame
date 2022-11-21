using UnityEngine;
using UnityEngine.UI;

namespace MathGame.UI
{
    public class GameFrame : MonoBehaviour
    {
        [SerializeField] private FrameAssetHolder _frameAssetHolder;
        [SerializeField] private Image _frameImageComponent;
        
        private void Start()
        {
            _frameImageComponent.sprite = _frameAssetHolder.DefaultFrameAsset;
        }
    }
}