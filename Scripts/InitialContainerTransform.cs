using Godot;
using System;

public partial class InitialContainerTransform : Node
{
    CenterContainer centerContainer;

    public override void _Ready()
    {
        centerContainer = GetParent<CenterContainer>();

        centerContainer.Size = DisplayServer.WindowGetSize();
        centerContainer.Position = new(0, 0);
    }
}
