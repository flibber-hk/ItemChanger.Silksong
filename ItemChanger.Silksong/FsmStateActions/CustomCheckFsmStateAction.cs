using HutongGames.PlayMaker;
using HutongGames.PlayMaker.Actions;

namespace ItemChanger.Silksong.FsmStateActions;

public class CustomCheckFsmStateAction : FSMUtility.CheckFsmStateAction
{
    public required Func<bool> GetIsTrue;

    public override bool IsTrue => GetIsTrue();

    public CustomCheckFsmStateAction() { }

    public CustomCheckFsmStateAction(FSMUtility.CheckFsmStateAction orig)
    {
        trueEvent = orig.trueEvent;
        falseEvent = orig.falseEvent;
        storeValue = orig.storeValue;
    }

    public CustomCheckFsmStateAction(PlayerDataBoolTest orig)
    {
        trueEvent = orig.isTrue;
        falseEvent = orig.isFalse;
        storeValue = new FsmBool("ITEMCHANGER DUMMY BOOL");
    }

    public CustomCheckFsmStateAction(PlayerDataVariableTest orig)
    {
        trueEvent = orig.IsExpectedEvent;
        falseEvent = orig.IsNotExpectedEvent;
        storeValue = new FsmBool("ITEMCHANGER DUMMY BOOL");
    }
}
