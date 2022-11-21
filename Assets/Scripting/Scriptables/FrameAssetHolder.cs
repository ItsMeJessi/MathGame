using UnityEngine;

[CreateAssetMenu(menuName = "GameAssetHolders/UI/Frame", fileName = "Frames", order = 1)]
public class FrameAssetHolder : ScriptableObject
{
    [SerializeField] private Sprite _defaultFrameAsset;
    [SerializeField] private Sprite _redFrameAsset;
    [SerializeField] private Sprite _greenFrameAsset;

    public Sprite DefaultFrameAsset => _defaultFrameAsset;
    public Sprite RedFrameAsset => _redFrameAsset;
    public Sprite GreenFrameAsset => _greenFrameAsset;
}
