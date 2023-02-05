using UnityEngine;

public class DivisionGenerator : EquationGenerator
{
    protected override void SetNumbers()
    {
        base.SetNumbers();
        _missingNumber = Random.Range(_minValue, _maxValue);
        _resultNumber = Random.Range(_minValue, _maxValue);
        _givenNumber = _missingNumber * _resultNumber;
        
        //24/6 = 4
        //24 = 6 * 4;

    }
}
