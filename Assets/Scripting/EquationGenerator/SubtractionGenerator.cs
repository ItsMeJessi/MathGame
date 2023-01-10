
using UnityEngine;

public class SubtractionGenerator : EquationGenerator
{
    protected override void SetNumbers()
    {
        base.SetNumbers();
        _missingNumber = _givenNumber - _resultNumber;
    }

    protected override int GetResultNumber()
    {
        return Random.Range(_minValue, _givenNumber - 1);
    }
}
