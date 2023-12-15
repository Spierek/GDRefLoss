using Godot;
using System;

public partial class ScriptB : Node2D
{
	[Export] private Sprite2D m_PrivateS2D;
	[Export] public Sprite2D m_PublicS2D;
}
