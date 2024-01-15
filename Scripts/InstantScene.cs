using Godot;
using System;

public partial class InstantScene : Node
{
	[Export]
	PackedScene[] scenes = new PackedScene[4];

	PackedScene onlyStage;

	public override void _Input(InputEvent @event)
	{
		DebugTest(@event);
	}

	void Instant(PackedScene packedScene)
	{
		foreach (Node i in GetChildren())
		{
			i.QueueFree();
		}
		onlyStage = packedScene;
		Node scene = onlyStage.Instantiate();
		AddChild(scene);
	}

	void DebugTest(InputEvent @event)
	{
		if (@event is InputEventKey inputEventKey)
		{
			switch (inputEventKey.Keycode)
			{
				case Key.A: Instant(scenes[0]); break;
				case Key.S: Instant(scenes[1]); break;
				case Key.D: Instant(scenes[2]); break;
				case Key.F: Instant(scenes[3]); break;
			}
		}
	}
}
