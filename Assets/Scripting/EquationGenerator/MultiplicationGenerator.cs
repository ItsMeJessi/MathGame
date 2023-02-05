using Random = UnityEngine.Random;

public class MultiplicationGenerator : EquationGenerator
{
    protected override void SetNumbers()
    {
        _missingNumber = Random.Range(_minValue, _maxValue);
        _resultNumber = _givenNumber * _missingNumber;
    }
}
