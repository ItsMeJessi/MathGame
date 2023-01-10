public class AdditionGenerator : EquationGenerator
{
    protected override void SetNumbers()
    {
        base.SetNumbers();
        _missingNumber = _resultNumber - _givenNumber;
    }
}
