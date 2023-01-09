
public class ButtonLocker : AbstractButton
{
    protected override void OnEnable()
    {
        base.OnEnable();
        GameActions.LockButtons += LockButton;
        GameActions.UnlockButtons += UnlockButton;
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        GameActions.LockButtons -= LockButton;
        GameActions.UnlockButtons -= UnlockButton;
    }
}
