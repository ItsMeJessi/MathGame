using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private EquationGenerator _equationGenerator;
    
    public static GameManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void LoadNextEquation()
    {
        _equationGenerator.GenerateEquation();
    }
}
