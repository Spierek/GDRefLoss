using Godot;
using System;

public partial class RefHolder : Node2D
{
	[Export] private Node2D m_PrivateRefN2D;
	[Export] public Node2D m_PublicRefN2D;

	[Export] private ScriptA m_PrivateA;
	[Export] public ScriptA m_PublicA;
	
	[Export] private ScriptB m_PrivateB;
	[Export] public ScriptB m_PublicB;
}
