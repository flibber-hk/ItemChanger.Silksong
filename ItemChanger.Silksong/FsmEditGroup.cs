using System.Collections.Generic;

namespace ItemChanger.Silksong;

public class FsmEditGroup : IDisposable
{
    private List<(FsmId, Action<PlayMakerFSM>)> edits = [];

    public void Add(FsmId id, Action<PlayMakerFSM> edit)
    {
        edits.Add((id, edit));
        SilksongEvents.AddFsmEdit(id, edit);
    }

    public void Dispose()
    {
        foreach (var (id, edit) in edits)
        {
            SilksongEvents.RemoveFsmEdit(id, edit);
        }
    }
}
